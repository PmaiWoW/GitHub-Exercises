using System;
using System.Collections.Generic;
using System.Text;

namespace ex23_poo
{
    public class Gun : Weapon
    {
        private Bullet[] bullets;
        public int NumberOfBullets => bullets.Length;

        public Gun(float value, int numBullets, float calibre) : base(value)
        {
            bullets = new Bullet[numBullets];
            for (int i = 0; i < numBullets; i++)
            {
                bullets[i] = new Bullet() { Calibre = calibre };
            }
        }
    }
}
