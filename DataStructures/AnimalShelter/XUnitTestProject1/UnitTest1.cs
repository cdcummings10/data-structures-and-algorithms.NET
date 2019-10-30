using System;
using Xunit;
using AnimalShelters;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestIfDogCanBeAddedToQueue()
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

            Assert.Equal(dog1, animalShelter.Head);
        }
        [Fact]
        public void TestIfCatCanBeAddedToQueue()
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            AnimalShelter animalShelter = new AnimalShelter();

            animalShelter.Enqueue(cat1);
            animalShelter.Enqueue(dog1);
            animalShelter.Enqueue(dog2);
            animalShelter.Enqueue(dog3);
            animalShelter.Enqueue(cat2);
            animalShelter.Enqueue(cat3);

            Assert.Equal(cat1, animalShelter.Head);
        }
        [Fact]
        public void TestIfItemCanBeDequeued()
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

            Animal answer = animalShelter.Dequeue("dog");

            Assert.Equal(dog1, answer);
        }
        [Fact]
        public void TestIfItemNotAtFrontCanBeDeQueued()
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

            Assert.Equal(cat1, answer);
        }
        [Fact]
        public void TestIfIncorrectStringReturnsNull()
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

            Animal answer = animalShelter.Dequeue("penguin");

            Assert.NotEqual(cat1, answer);
        }
    }
}
