using NUnit.Framework;
namespace Divisors
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, DivisorsClass.FindDivisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, DivisorsClass.FindDivisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, DivisorsClass.FindDivisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, DivisorsClass.FindDivisors(24));
        }
    }
}
