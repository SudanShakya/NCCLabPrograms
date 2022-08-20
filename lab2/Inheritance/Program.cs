using System;
namespace Inheritance
{
    //base class
    class Animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am an animal.");
        }
    }

    // derived class of an Animal
    class Dog:Animal
    {
        public void getName()
        {
            Console.WriteLine($"My name is {name}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //object of derived class
            Dog Beagle = new Dog();

            //access field and method of base class
            Beagle.name = "Gaint";
            Beagle.display();

            //access metod from own class
            Beagle.getName();
            Console.ReadLine();

        }
    }
}