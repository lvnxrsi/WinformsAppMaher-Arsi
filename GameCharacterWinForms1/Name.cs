using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCharacterWinForms1
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void Name_Load(object sender, EventArgs e)
        {
 
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Loading loadingForm = new Loading();
            loadingForm.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
