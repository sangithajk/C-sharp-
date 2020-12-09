using System;

namespace AddAndConvertToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(1,2));
        }
        public static string AddBinary(int a, int b)
        {
            // your code ...
            // Convert.ToString -> 2nd parameter will define the format of output. 2 is for binary
           

            var sum = a + b;
            return Convert.ToString(sum,2);
        }
    }
}
