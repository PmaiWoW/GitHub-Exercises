﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ex07_UML
{
    class Player
    {
        public int ID { get; }
        public string Name { get; }
        private readonly double health;
        private readonly double shield;

        public Player(int id, string name, double health, double shield)
        {
            ID = id;
            Name = name;
            this.health = health;
            this.shield = shield;
        }

        public void PrintPlayerName() => Console.WriteLine($"{Name}\n");
    }
}
