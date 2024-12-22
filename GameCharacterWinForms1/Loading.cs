using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCharacterWinForms1
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.Load += new EventHandler(Loading_Load);
        }

        private async void Loading_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(10);
            }

            await Task.Delay(1000);

            this.Close();
            SelectCharacter selectCharacterForm = new SelectCharacter();
            selectCharacterForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
