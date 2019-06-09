using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ex62_poo
{
    class Program
    {
        public static void Main()
        {
            float number;
            WriteLine("Escreve um número: ");
            number = ToSingle(ReadLine());
            WriteLine("O coseno desse número é {0:f3}", Cos(number));
        }
    }
}
