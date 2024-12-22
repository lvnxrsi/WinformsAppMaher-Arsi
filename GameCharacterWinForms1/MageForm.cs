using System;
using System.Drawing;
using System.Windows.Forms;
using GameCharacterWinForms1.Models;

namespace GameCharacterWinForms1
{
    public partial class MageForm : Form
    {
        public MageForm()
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

        private void textMana_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonStartMage_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            if (int.TryParse(textLevel.Text, out int level) &&
                int.TryParse(textHealth.Text, out int health) &&
                int.TryParse(textMana.Text, out int mana))
            {
             

                Mage mage = new Mage(name, level, health, mana, 0);

                Loading loadingForm = new Loading();
                loadingForm.ShowDialog();

                GameplayMage gameplayForm = new GameplayMage(mage);
                gameplayForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Level, Health, and Mana.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MageForm_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureMage;
            label1.BackColor = Color.Transparent;
            label1.Invalidate();

            label2.Parent = pictureMage;
            label2.BackColor = Color.Transparent;
            label2.Invalidate();

            label3.Parent = pictureMage;
            label3.BackColor = Color.Transparent;
            label3.Invalidate();

            label4.Parent = pictureMage;
            label4.BackColor = Color.Transparent;
            label4.Invalidate();
        }
    }
}
