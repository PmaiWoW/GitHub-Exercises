using System;
using System.Collections.Generic;
using System.Text;

namespace ex08_UML
{
    public class Olaf : NPC
    {
        Random rng = new Random();

        public Olaf(float hp) : base(hp) { }

        protected override void AttackEnemies()
        {
            Console.WriteLine("Olaf attacks his enemies!");
        }

        protected override void EatFood()
        {
            Console.WriteLine("Olaf eats Roasted Goat.");
        }

        protected override bool FindEnemies()
        {
            int perception = rng.Next(0, 100);

            if (perception > 35) return true;
            else return false;
        }

        protected override bool FindFood()
        {
            int perception = rng.Next(0, 100);

            if (perception > 15) return true;
            else return false;
        }
    }
}
