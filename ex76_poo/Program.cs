using System;

namespace ex76_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums1 = new double[10] { 2, 1, 3, 23, 5, 6, 7, 4, 1, 1 };
            double[] nums2 = new double[9] { 2, 1, 3, 4, 5, 4, 4, 6, 1 };
            Tuple<double, double, double, double, double> tupStats1;
            Tuple<double, double, double, double, double> tupStats2;

            double minimo1, minimo2, maximo1, maximo2, media1, media2,
                mediana1, mediana2, moda1, moda2;

            Stats.OutStats(out minimo1, out maximo1, out media1, out mediana1, 
                out moda1, nums1);
            Stats.OutStats(out minimo2, out maximo2, out media2, out mediana2, 
                out moda2, nums2);

            Console.WriteLine($"Minimo1: {minimo1}\nMaximo1: {maximo1}\n" +
                $"Media1: {media1}\nMediana1: {mediana1}\nModa1: {moda1}\n");

            Console.WriteLine($"Minimo2: {minimo2}\nMaximo2: {maximo2}\n" +
                $"Media2: {media2}\nMediana2: {mediana2}\nModa2: {moda2}\n");
            
            tupStats1 = Stats.TupleStats(nums1);
            tupStats2 = Stats.TupleStats(nums2);

            Console.WriteLine($"Minimo1: {tupStats1.Item1}\nMaximo1: " +
                $"{tupStats1.Item2}\nMedia1: {tupStats1.Item3}\nMediana1: " +
                $"{tupStats1.Item4}\nModa1: {tupStats1.Item5}\n");

            Console.WriteLine($"Minimo2: {tupStats2.Item1}\nMaximo2: " +
                $"{tupStats2.Item2}\nMedia2: {tupStats2.Item3}\nMediana2: " +
                $"{tupStats2.Item4}\nModa2: {tupStats2.Item5}\n");
        }
    }
}
