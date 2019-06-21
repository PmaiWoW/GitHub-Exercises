using System;

namespace ex75_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums1 = new double[10] { 2, 1, 3, 23, 5, 6, 7, 4, 1, 1 };

            Console.WriteLine($"Maximo1: {Stats.Maximo(nums1)}\n" +
                $"Minimo1: {Stats.Minimo(nums1)}\nMedia1: {Stats.Media(nums1)}" +
                $"\nMediana1: {Stats.Mediana(nums1)}\n" +
                $"Moda1: {Stats.Moda(nums1)}\n");

            double[] nums2 = new double[9] { 2, 1, 3, 4, 5, 4, 4, 6, 1 };

            Console.WriteLine($"Maximo2: {Stats.Maximo(nums2)}\n" +
                $"Minimo2: {Stats.Minimo(nums2)}\nMedia2: {Stats.Media(nums2)}" +
                $"\nMediana2: {Stats.Mediana(nums2)}\n" +
                $"Moda2: {Stats.Moda(nums2)}\n");
        }
    }
}
