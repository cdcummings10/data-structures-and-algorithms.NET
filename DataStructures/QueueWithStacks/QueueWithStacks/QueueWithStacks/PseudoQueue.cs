using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        private Stack<int> storageStack = new Stack<int>();
        private Stack<int> answerStack = new Stack<int>();
        public int Front { get; set; }
        public int Rear { get; set; }


        public void Enqueue(int num)
        {
            if (storageStack.Count == 0)
            {
                Front = num;
            }
            storageStack.Push(num);
            Rear = num;
        }
        public int Dequeue()
        {
            if (storageStack.Count != 0)
            {
                foreach (int num in storageStack)
                {
                    answerStack.Push(storageStack.Pop());
                }
                int answer = answerStack.Pop();
                foreach (int num in answerStack)
                {
                    storageStack.Push(answerStack.Pop());
                }
                return answer;
            }
            else { return -1; }
        }
    }
}
