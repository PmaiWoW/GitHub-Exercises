using System;
using System.Collections.Generic;
using System.Text;

namespace ex38_poo
{
    public class PNGTexture : Texture
    {
        private string pngName;

        public PNGTexture(string textureFile) : base(textureFile)
        {
            pngName = $"{textureFile}.png";
        }

        public override string ToString() { return $"PNG File Name: " +
                $"{pngName}"; }
    }
}
