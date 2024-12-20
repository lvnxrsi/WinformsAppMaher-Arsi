using System;

namespace GameCharacterWinForms1.Models
{
    public class Warrior : GameCharacter
    {
        public int Armor { get; set; }

        // Adjust the constructor to match the order of parameters
        public Warrior(string name, int level, int strength, int health, int intelligence)
            : base(name, level, health, strength, intelligence, 0)
        {
            Armor = 10;
        }

        public override void Attack()
        {
            int baseDamage = Strength * 2;
            bool criticalHit = new Random().Next(100) < 20;
            int finalDamage = criticalHit ? baseDamage * 2 : baseDamage;
            Console.WriteLine($"{Name} dealt {finalDamage} damage. Critical Hit: {criticalHit}");
        }

        public override void Defend()
        {
            int damageReduction = Armor / 2;
            bool blockChance = new Random().Next(100) < 15;
            if (blockChance)
            {
                Console.WriteLine(Name + " blocked the attack.");
            }
            else
            {
                Console.WriteLine(Name + " reduced the damage by " + damageReduction);
            }
        }

        public override void LevelUp()
        {
            Level += 1;
            Strength += 5;
            Health += 10;
            Armor += 2;
            Console.WriteLine($"{Name} leveled up to {Level}! Strength: {Strength}, Health: {Health}, Armor: {Armor} increased!");
        }
    }
}