using System;
using System.Collections.Generic;

namespace ex76_poo
{
    static class Stats
    {
        public static double Minimo(params double[] nums)
        {
            Array.Sort(nums);
            return nums[0];
        }

        public static double Maximo(params double[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1];
        }

        public static double Media(params double[] nums)
        {
            double total = 0;

            foreach (double d in nums)
            {
                total += d;
            }

            return (total / (nums.Length));
        }

        public static double Mediana(params double[] nums)
        {
            Array.Sort(nums);

            if (nums.Length % 2 == 0)
            {
                int numsUp = nums.Length / 2;
                int numsDown = nums.Length / 2 - 1;
                return (nums[numsUp] + nums[numsDown]) / 2;
            }
            else return nums[nums.Length / 2];
        }

        public static double Moda(params double[] nums)
        {
            double maxKey = 0;
            double max = 0;

            Dictionary<double, int> count =
                new Dictionary<double, int>();

            foreach (double dKey in nums)
            {
                // each double dKey in nums is used as a key to a value that is
                // it's count in the array; if dKey (key) is already in the
                // dictionary, it's count (value) increases by one, otherwise
                // (it is not in the dictionary) it's count is 1;
                if (count.ContainsKey(dKey)) count[dKey]++;
                if (!(count.ContainsKey(dKey))) count[dKey] = 1;
            }

            foreach (double dKey in nums)
            {
                if (count[dKey] > max)
                {
                    max = count[dKey];
                    maxKey = dKey;
                }
            }

            return maxKey;
        }

        public static Tuple<double, double, double, double, double>
            TupleStats(params double[] nums)
        {
            return new Tuple<double, double, double, double, double>
                (Minimo(nums), Maximo(nums), Media(nums),
                Mediana(nums), Moda(nums));
        }

        public static void OutStats(out double minimo, out double maximo,
            out double media, out double mediana, out double moda,
            params double[] nums)
        {
            minimo = Minimo(nums);
            maximo = Maximo(nums);
            media = Media(nums);
            mediana = Mediana(nums);
            moda = Moda(nums);
        }
    }
}
