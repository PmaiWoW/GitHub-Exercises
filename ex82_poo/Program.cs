using System;

namespace ex82_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Insert what you want to convert:");
                input = Console.ReadLine();
                if (byte.TryParse(input, out byte b))
                {
                    Console.WriteLine($"Input is parseable, value is:\n" +
                        $"{b}\n");
                }
                else
                {
                    Console.WriteLine("Input not parseable to byte, try " +
                        "again\n");
                }
            } while (input != "");
        }
    }
}
