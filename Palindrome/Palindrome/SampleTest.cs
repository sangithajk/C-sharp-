using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace Palindrome
{
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public  static void Sample_test1()
        {
            Console.WriteLine("Inside test");
            Assert.IsTrue(Program.Palindrome("roadaor"));
        }
    }
}
