
using System;
using NUnit.Framework;
using QDS = CSharpPractice.Data_Structures;

namespace AlgorithmTests
{
    [TestFixture]
    public class Queue_Data_Structure_tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Queue_Data_Structure()
        {
            QDS.Queue q = new QDS.Queue();
            q.enqueue(10);
            q.enqueue(20);
            q.dequeue();
            q.dequeue();
            q.enqueue(30);
            q.enqueue(40);
            q.enqueue(50);
            q.dequeue();
            Assert.AreEqual(40, q.front.key);
            Assert.AreEqual(50, q.rear.key);
        }
    }
}
