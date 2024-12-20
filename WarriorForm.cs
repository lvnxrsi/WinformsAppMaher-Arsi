using GameCharacterWinForms1.Models;
using System;
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
            
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
