using System;

namespace ex68_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            AwesomeList<int> intList = new AwesomeList<int>() { 1, 3, 6, 7, 8,
            87, 13, 513, 634 };

            Console.WriteLine(intList);
        }
    }
}
