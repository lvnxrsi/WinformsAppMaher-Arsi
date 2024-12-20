using GameCharacterWinForms1.Models;
using GameCharacterWinForms1;
using System;

namespace GameCharacterWinForms1.Models
{
    public class Mage : GameCharacter
    {
        public int SpellPower { get; set; }

        public Mage(string name, int level, int health, int mana, int intelligence)
            : base(name, level, health, mana, 0, intelligence)
        {
            SpellPower = 10;
        }

        public override void Attack()
        {
            int magicDamage = Intelligence * 3 + SpellPower;
            bool burningEffect = new Random().Next(100) < 25;
            Console.WriteLine($"{Name} dealt {magicDamage} magic damage. Burning Effect: {burningEffect}");
        }

        public override void Defend()
        {
            int damageReduction = Mana / 4;
            bool evadeChance = new Random().Next(100) < 20;
            if (evadeChance)
            {
                Console.WriteLine(Name + " evaded the attack!");
            }
            else
            {
                Console.WriteLine(Name + " reduced the damage by " + damageReduction);
            }
        }

        public override void LevelUp()
        {
            Level += 1;
            Intelligence += 5;
            Mana += 15;
            SpellPower += 3;
            Console.WriteLine($"{Name} leveled up to {Level}! Intelligence: {Intelligence}, Mana: {Mana}, Spell Power: {SpellPower} increased!");
        }
    }
}
