using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PseudoQueue testQueue = new PseudoQueue();
            testQueue.Enqueue(1);
            testQueue.Enqueue(4);
            testQueue.Enqueue(12);
            testQueue.Enqueue(15);

            Console.WriteLine(testQueue.Dequeue());
        }
    }
}
