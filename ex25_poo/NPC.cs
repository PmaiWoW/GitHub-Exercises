using System;
using System.Collections.Generic;
using System.Text;

namespace ex25_poo
{
    class NPC : Character
    {
        private Random rnd;
        private readonly string directions;

        public NPC(string name) : base(name)
        {
            rnd = new Random();
            directions = "NSWE";
        }

        public override char Move() => directions[rnd.Next(directions.Length)];
    }
}
