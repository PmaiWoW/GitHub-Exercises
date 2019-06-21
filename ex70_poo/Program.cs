using System;

namespace ex70_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert value for X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert value for Y:");
            y = Convert.ToInt32(Console.ReadLine());

            ValueSwitch(ref x, ref  y);

        }

        static void ValueSwitch<T>(<T> x, <T> y)
        {

        }
    }
}
