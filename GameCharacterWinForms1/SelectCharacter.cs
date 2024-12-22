using System;
using System.Windows.Forms;
using GameCharacterWinForms1.Models;

namespace GameCharacterWinForms1
{
    public partial class SelectCharacter : Form
    {
        public SelectCharacter()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            var warriorForm = new WarriorForm();
            warriorForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var mageForm = new MageForm();
            mageForm.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
    

