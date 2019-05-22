using System;
using System.Collections.Generic;
using System.Text;

namespace ex31_poo
{
    public class Trap : GameObject
    {
        public override int Priority() { return int.MaxValue; }
        public void DisableTrap() { Console.WriteLine("Trap is " +
            "now disabled."); }
    }
}
