using System;
using System.Collections.Generic;
using System.Text;

namespace ex31_poo
{
    class PowerUp : GameObject, ITaggable
    {
        public string Tag { get; set; }

        public override int Priority() => Tag.Length;

        public override bool IsActive() => (Tag == null || Tag.Length == 0) ?
            false : true;

        public override string ToString() => $"X:{X}\nY:{Y}\nTag:{Tag}\n";
    }
}
