using SlotMachine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        public Form1()
        {
            InitializeComponent();

            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3 };

            // Create Reel objects for each PictureBox
            Reel[] reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i]);
            }

            // Initialize SlotMachine object with an initial balance of 1000
            slotMachine = new Slot(1000, reels);

            // Update the balance label on the form
            lblBalance.Text = "Balance: P" + slotMachine.Balance;

            // Add a transparent button
            btnSpin.FlatStyle = FlatStyle.Flat;
            btnSpin.FlatAppearance.BorderSize = 0;
            btnSpin.BackColor = Color.Transparent;
            btnSpin.FlatAppearance.MouseOverBackColor = Color.Transparent;  // Stay transparent on hover
            btnSpin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSpin.Text = "";
        }

        async void btnSpin_Click(object sender, EventArgs e)
        {
            // Validate the stake amount
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                // Deduct the stake and update balance
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                // Disable the spin button during the spin
                btnSpin.Enabled = false;

                // Clear the previous result
                lblResult.Text = "";
                lblResult.ForeColor = Color.Black;

                // Simulate spinning the reels
                await SimulateSpinAsync();

                // Check the results after spinning
                int winnings = slotMachine.CheckResult();
                slotMachine.UpdateBalance(winnings);

                // Display the result
                if (winnings > 0)
                {
                    lblResult.Text = $"🎉 WIN! You earned P{winnings} 🎉";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "No luck this time!";
                    lblResult.ForeColor = Color.Red;
                }

                // Update the balance label
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                // Re-enable the spin button
                btnSpin.Enabled = true;
                txtStake.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }
        }

        private async Task SimulateSpinAsync()
        {
            int spinDuration = 20; // Number of spins to simulate
            int delay = 100;       // Delay in milliseconds between spins

            for (int i = 0; i < spinDuration; i++)
            {
                // Spin the reels
                slotMachine.Spin();

                // Wait for the delay
                await Task.Delay(delay);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

 
}
    

