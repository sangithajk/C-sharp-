using System;
using System.Collections.Generic;
namespace Divisors
{
    public class DivisorsClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindDivisors(15));
        }

        public static int[] FindDivisors(int n)
        {
            List<int> out1 = new List<int> { };
            int[] output = new int[] { };

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) out1.Add(i);

            }

            output = out1.ToArray();
            return output;
        }
        
    }
}
