using System;

namespace ex86_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x;
            int y;
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insert positive value for x:");
                x = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Insert value for y:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Saturate(x, ref y));
                Console.WriteLine(y);
            }
        }

        public static bool Saturate(uint x, ref int y)
        {
            if (y > x)
            {
                y = (int)x;
                return true;
            }
            if (y < -x)
            {
                y = (int)-x;
                return true;
            }

            return false;
        }
    }
}
