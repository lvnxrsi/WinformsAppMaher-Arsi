using System;
using System.Windows.Forms;
using GameCharacterWinForms1.Models;

namespace GameCharacterWinForms1
{
    public partial class Gameplay : Form
    {
        private Warrior _character;

        public Gameplay(Warrior character)
        {
            InitializeComponent();
            _character = character;

            listDetails.Items.Add($"Name: {_character.Name}");
            listDetails.Items.Add($"Level: {_character.Level}");
            listDetails.Items.Add($"Health: {_character.Health}");
            listDetails.Items.Add($"Strength: {_character.Strength}");
            listDetails.Items.Add($"Intelligence: {_character.Intelligence}");
        }



        private void Gameplay_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Name nameForm = new Name();
            nameForm.Show();
        }

        private void buttonLevelUp_Click_1(object sender, EventArgs e)
        {
            _character.Level++;
            _character.Health += 10;
            _character.Strength += 5;
            _character.Intelligence += 5;

            listLog.Items.Add($"{_character.Name} leveled up to level {_character.Level}!");

            listDetails.Items[1] = $"Level: {_character.Level}";
            listDetails.Items[2] = $"Health: {_character.Health}";
            listDetails.Items[3] = $"Strength: {_character.Strength}";
            listDetails.Items[4] = $"Intelligence: {_character.Intelligence}";

        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            int damage = _character.Strength * 2;
            listLog.Items.Add($"{_character.Name} attacked and dealt {damage} damage!");

            _character.Health -= damage / 4;
            if (_character.Health < 0) _character.Health = 0;

            listDetails.Items[2] = $"Health: {_character.Health}";
        }

        private void buttonDefend_Click_1(object sender, EventArgs e)
        {
            listLog.Items.Add($"{_character.Name} defended and took reduced damage.");
        }

        private void listLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
