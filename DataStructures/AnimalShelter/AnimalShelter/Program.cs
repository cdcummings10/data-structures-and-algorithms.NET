using System;

namespace AnimalShelters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            AnimalShelter animalShelter = new AnimalShelter();

            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(dog3);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(cat3);

            Animal answer = animalShelter.Dequeue("cat");

        }
    }
}
