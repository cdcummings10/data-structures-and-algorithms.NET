using System;
using Xunit;
using QueueWithStacks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public PseudoQueue testQueue = new PseudoQueue();
        [Fact]
        public void TestIfYouCanEnqueueAValue()
        {
            testQueue.Enqueue(1);
            testQueue.Enqueue(4);
            testQueue.Enqueue(12);
            testQueue.Enqueue(15);
            testQueue.Enqueue(44);
            testQueue.Enqueue(9);

            Assert.Equal(9, testQueue.Rear);
        }
        [Fact]
        public void TestIfDequeueDoesNotGiveLastValueAdded()
        {
            testQueue.Enqueue(1);
            testQueue.Enqueue(4);
            testQueue.Enqueue(12);
            testQueue.Enqueue(15);
            testQueue.Enqueue(44);
            testQueue.Enqueue(9);

            Assert.NotEqual(9, testQueue.Dequeue());
        }
        [Fact]
        public void TestifYouCanDequeueAnItemAndItsTheLastItemAdded()
        {
            testQueue.Enqueue(1);
            testQueue.Enqueue(4);
            testQueue.Enqueue(12);

            Assert.Equal(1, testQueue.Dequeue());
        }
        
    }
}
