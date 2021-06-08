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
            Searching s1 = new Searching(input,4 );
            Searching s2 = new Searching(input,8 );
            Searching s3 = new Searching(input,12);
            Searching s4 = new Searching(input,34);

            //Binary search tests
            //Normal search
            Assert.AreEqual(2, s1.BinarySearch());
            Assert.AreEqual(4, s2.BinarySearch());
            Assert.AreEqual(6, s3.BinarySearch());
            Assert.AreEqual(7, s4.BinarySearch());
            //Recursive Search
            Assert.AreEqual(2, s1.RecursiveBinarySearch());
            Assert.AreEqual(4, s2.RecursiveBinarySearch());
            Assert.AreEqual(6, s3.RecursiveBinarySearch());
            Assert.AreEqual(7, s4.RecursiveBinarySearch());
        }
    }
}