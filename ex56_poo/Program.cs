using System;
using System.Collections.Generic;

namespace ex56_poo
{
    public class Problem
    {
        public static void Main()
        {
            // Um array de objetos de diferentes tipos
            object[] stuff = { "ola", 1, 2.3, 5f, 12L, 4UL, 5U, "bye", 4, 9 };
            // Imprimir apenas objetos do tipo int
            foreach (int i in Filter<int>(stuff))
            {
                Console.WriteLine("int = " + i);
            }
            // Imprimir apenas objetos do tipo float
            foreach (float f in Filter<float>(stuff))
            {
                Console.WriteLine("float = " + f);
            }
        }

        static IEnumerable<T> Filter<T>(IEnumerable<object> stuff)
        {
            foreach (object obj1 in stuff)
            {
                if (obj1 is T obj2) yield return obj2;
            }
        }
    }
}
