using GameCharacterWinForms1.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameCharacterWinForms1
{
    public partial class WarriorForm : Form
    {
        public WarriorForm()
        {
            InitializeComponent();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textStrength_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIntelligence_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            string name = textName.Text;

            if (!int.TryParse(textLevel.Text, out int level))
            {
                MessageBox.Show("Level must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textStrength.Text, out int strength))
            {
                MessageBox.Show("Strength must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textHealth.Text, out int health))
            {
                MessageBox.Show("Health must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textIntelligence.Text, out int intelligence))
            {
                MessageBox.Show("Intelligence must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            Warrior warrior = new Warrior(name, level, strength, health, intelligence);

          
            Loading loadingForm = new Loading();
            loadingForm.ShowDialog();

           
            Gameplay gameplayForm = new Gameplay(warrior);
            gameplayForm.Show();

            
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Name nameForm = new Name();
            nameForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void WarriorForm_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureFighter;
            label1.BackColor = Color.Transparent;
            label1.Invalidate();

            label2.Parent = pictureFighter;
            label2.BackColor = Color.Transparent;
            label2.Invalidate();

            label3.Parent = pictureFighter;
            label3.BackColor = Color.Transparent;
            label3.Invalidate();

            label4.Parent =pictureFighter;
            label4.BackColor = Color.Transparent;
            label4.Invalidate();

            label5.Parent = pictureFighter;
            label5.BackColor = Color.Transparent;
            label5.Invalidate();


        }
    }
}
