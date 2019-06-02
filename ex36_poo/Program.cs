using System;
using System.Collections.Generic;

namespace ex36_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            List<int> ints = new List<int>();

            Console.WriteLine("What number will be copied into the list?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times will the number be copied?");
            n = int.Parse(Console.ReadLine());

            ints = ListNumber(x, n);

            foreach(int i in ints)
            {
                Console.WriteLine(ints[i]);
            }
        }

        static List<int> ListNumber(int x, int n)
        {
            List<int> ints = new List<int>();

            for(int i = 0; i < n; i++)
            {
                ints.Add(x);
            }

            return ints;
        }
    }
}
