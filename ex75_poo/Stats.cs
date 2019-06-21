using System;
using System.Collections.Generic;

namespace ex75_poo
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
    }
}
