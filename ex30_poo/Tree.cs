using System;
using System.Collections.Generic;
using System.Text;

namespace ex30_poo
{
    class Tree
    {
        private string type;
        private float height;

        public Tree(string type, float height)
        {
            this.type = type;
            this.height = height;
        }

        public override string ToString()
        {
            return $"Type: {this.type}\nHeight: {this.height}";
        }
    }
}
