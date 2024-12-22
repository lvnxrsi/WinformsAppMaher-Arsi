using System;
using System.Windows.Forms;
using GameCharacterWinForms1.Models;

namespace GameCharacterWinForms1
{
    public partial class GameplayMage : Form

    {
        private GameCharacter _character;

        public GameplayMage(GameCharacter character)
        {
            InitializeComponent();
            _character = character;

          
            listDetails.Items.Add($"Name: {_character.Name}");
            listDetails.Items.Add($"Level: {_character.Level}");
            listDetails.Items.Add($"Health: {_character.Health}");
            listDetails.Items.Add($"Mana: {_character.Mana}");
            
        }

        private void buttonAttack_Click_1(object sender, EventArgs e)
        {
            
            int damage = _character.Strength * 2;
            listLog.Items.Add($"{_character.Name} attacked and dealt {damage} damage!");

           
            _character.Health -= damage / 4;
            if (_character.Health < 0) _character.Health = 0;

           
            listDetails.Items[2] = $"Health: {_character.Health}";
        }

        private void buttonDefend_Click(object sender, EventArgs e)
        {
            
            listLog.Items.Add($"{_character.Name} defended and took reduced damage.");
        }

        private void Gameplay_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonLevelUp_Click(object sender, EventArgs e)
        {

            _character.Level++;
            _character.Health += 10;
            _character.Mana += 5;


            listLog.Items.Add($"{_character.Name} leveled up to level {_character.Level}!");


            listDetails.Items[1] = $"Level: {_character.Level}";
            listDetails.Items[2] = $"Health: {_character.Health}";
            listDetails.Items[3] = $"Mana: {_character.Mana}";
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Name nameForm = new Name();
            nameForm.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Name nameForm = new Name();
            nameForm.Show();
        }
    }
    }

