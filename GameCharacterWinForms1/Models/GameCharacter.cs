﻿using System;

namespace GameCharacterWinForms1.Models
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
            Strength = strength;
            Intelligence = intelligence;
        }

        public abstract void Attack();
        public abstract void Defend();
        public abstract void LevelUp();

        public override string ToString()
        {
            return $"{Name} - Level: {Level}, Health: {Health}, Mana: {Mana}, Strength: {Strength}, Intelligence: {Intelligence}";
        }
    }
}
