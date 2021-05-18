using NUnit.Framework;
using CSharpPractice.Searching_Algorithms;

namespace AlgorithmTests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinarySearch_SortedInput_CorrectIndex()
        {
            int[] input = { 0, 3, 4, 7, 8, 9, 12, 34, 56 };
            Assert.AreEqual(2, Searching.BinarySearch(input, 4));
            Assert.AreEqual(4, Searching.BinarySearch(input, 8));
            Assert.AreEqual(6, Searching.BinarySearch(input, 12));
            Assert.AreEqual(7, Searching.BinarySearch(input, 34));

            Assert.AreEqual(2, Searching.RecursiveBinarySearch(input, 4));
            Assert.AreEqual(4, Searching.RecursiveBinarySearch(input, 8));
            Assert.AreEqual(6, Searching.RecursiveBinarySearch(input, 12));
            Assert.AreEqual(7, Searching.RecursiveBinarySearch(input, 34));
        }
    }
}