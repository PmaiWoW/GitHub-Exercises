using System;
using System.Collections.Generic;
using System.Text;

namespace ex25_poo
{
    class Player : Character
    {
        public Player(string name) : base(name) { }

        public override char Move()
        {
            char mInput;

            Console.WriteLine("What direction will you move in?");
            mInput = Console.ReadLine().ToUpper()[0];

            switch (mInput)
            {
                case 'W': return 'N';
                case 'A': return 'W';
                case 'S': return 'S';
                case 'D': return 'E';
                default: return '?';
            }
        }

        public override string ToString() => $"Player Name: {Name}";
    }
}
