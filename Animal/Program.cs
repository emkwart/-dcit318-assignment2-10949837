using System;

namespace InheritanceDemo
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to hear a cat or dog sound?");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "cat")
            {
                Animal myCat = new Cat();
                myCat.MakeSound();
            }
            else if (userChoice == "dog")
            {
                Animal myDog = new Dog();
                myDog.MakeSound();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'cat' or 'dog'.");
            }

            Console.ReadLine();
        }
    }
}