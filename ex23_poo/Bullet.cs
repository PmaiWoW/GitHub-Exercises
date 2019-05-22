using System;
using System.Collections.Generic;
using System.Text;

namespace ex23_poo
{
    public struct Bullet
    {
        private float calibre;
        public float Calibre
        {
            get { return calibre; }
            set { if (value < 0.1f) calibre = 0.1f; else calibre = value; }
        }
    }
}
