using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("ramamar"));
            
        }
        public static bool Palindrome (string input)
        {
            var chararray = input.ToCharArray();
            Array.Reverse(chararray);
            if (input == new string(chararray))
                return true;
            else
                return false;

        }
    }
}
