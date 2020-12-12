using System;
using Divisors;
using NUnit.Framework;

namespace Divisors.Tests
{
     
   [TestFixture]
   public class DivisiorTests
    {
        [Test]
        public void SampleTests()
        {
            var result = DivisorsClass.FindDivisors(15);

            Assert.AreEqual(new int[] { 3, 5 }, result);

        }
    }
}
