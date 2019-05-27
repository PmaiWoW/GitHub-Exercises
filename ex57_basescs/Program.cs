using System;

namespace ex57_basescs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Process()
            {
                char[] a;
                a = new char[] { 'a', 'b', 'c' };
                MisteryOp(ref a);
                return a;
            }

            void MisteryOp(ref char[] a)
            {
                a = new char[] { a[2], a[1], a[0] };
            }

            char[] chars = new char[3];

            chars = Process();

            foreach(char c in chars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
