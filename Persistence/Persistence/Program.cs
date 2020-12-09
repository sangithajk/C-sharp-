using System;

namespace Persistence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(66276));
        }
        public static long Persistence(long n)
        {
            // your code
            int i = 10;
            long result = 1;
            int peristence = 0;
            while (Convert.ToString(n).Length > 1)
            {
                result = 1;
                peristence += 1;
                while (n > 1)
                {
                    result *= (n % i);
                    n /= i;
                    
                }
                n = result;
            }
            Console.WriteLine("persistence : " + peristence);
            return peristence;
        }
    }
}
        
        
        