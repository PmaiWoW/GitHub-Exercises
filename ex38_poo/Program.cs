using System;

namespace ex38_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            PNGTexture pngTexture;
            string filename;

            Console.WriteLine("What name will the file have?");
            filename = Console.ReadLine();

            pngTexture = new PNGTexture(filename);

            Console.WriteLine(pngTexture);
        }
    }
}
