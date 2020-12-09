using System;
using System.Text;

namespace Maskify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("Hello World!"));
        }
        public static string Maskify(string cc)
        {
            StringBuilder newstr = new System.Text.StringBuilder();
            for (int i = 0; i < cc.Length; i++)
            {
                if (i < cc.Length - 4)
                    newstr.Append("#");

                else
                    newstr.Append(cc[i]);
            }
            return Convert.ToString(newstr);
        }
    }
}
