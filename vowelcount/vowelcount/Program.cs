using System;
using System.Linq;

namespace vowelcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("Humpty Dumpty sat on wall. "));
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Your code here
            // Count used without any predicate will count the number of elements in source string
            // Count used with predicate will count the number of elements in source which satisfies the predicate
            // it is like a where clause

            vowelCount = str.Count(s => "aeiou".Contains(s));

            return vowelCount;
        }
        

    }
}
