using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters
{
    public class AnimalShelter
    {
        private Stack<Animal> storageStack = new Stack<Animal>();
        private Stack<Animal> answerStack = new Stack<Animal>();

        public Animal Head { get; set; } = null;

        public void Enqueue(Animal animal)
        {
            if (Head == null)
            {
                Head = animal;
            }
            storageStack.Push(animal);
        }

        public Animal Dequeue(string pref)
        {
            Animal answer = null;
            int count = storageStack.Count;

            for (int i = 0; i < count; i++)
            {
                answerStack.Push(storageStack.Pop());
            }
            for (int i = 0; i < count; i++)
            {
                Animal current = answerStack.Pop();
                if (answer == null)
                {
                    switch (pref)
                    {
                        case "dog":
                            if (current is Dog)
                            {
                                answer = current;
                            }
                            else
                            {
                                storageStack.Push(current);
                            }
                            break;
                        case "cat":
                            if (current is Cat)
                            {
                                answer = current;
                            }
                            else
                            {
                                storageStack.Push(current);
                            }
                            break;
                        default:
                            storageStack.Push(current);
                            break;
                    }
                }
                else
                {
                    storageStack.Push(current);
                }
            }
            return answer;
        }
    }
}
