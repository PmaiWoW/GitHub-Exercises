using System;
using System.Collections.Generic;
using System.Text;

namespace ex38_poo
{
    public class PNGTexture : Texture
    {
        public PNGTexture(string textureFile) : base(textureFile)
        {
            textureFile += ".png";
        }
    }
}
