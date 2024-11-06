using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        public class Animal
        {
            public string name;
            public int age;
            public bool alive;

            public void Eat()
            {
                Console.WriteLine("my animal is eating");
            }

        }
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"my {name} is Barking and he is {age} years old");
            }
        }


        class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine($"my cat name is {name} and she saying meow meow and she is {age} years old");
            }
        }



       
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            cat.name = "Lilly";
            dog.name = "Tommy";

            cat.age = 3;
            dog.age = 4;

            dog.Bark();
            cat.Meow();

            Console.ReadKey();
        }
    }
}
