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
                int storageCount = storageStack.Count;
                for (int i = 0; i < storageCount; i++)
                {
                    answerStack.Push(storageStack.Pop());
                }
                int answer = answerStack.Pop();
                int answerCount = answerStack.Count;

                for (int i = 0; i < answerCount; i++)
                {
                    storageStack.Push(answerStack.Pop());
                }
                return answer;
            }
            else { return -1; }
        }
    }
}
