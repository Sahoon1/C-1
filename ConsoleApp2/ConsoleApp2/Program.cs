using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class dog
        {
            public string name;
            public int age;

            public void bark ()
            {
                Console.WriteLine($"{name} says : woof ");
            }
        }



        class program
        {
            static void Main(string[] args)
            {
                dog mydog = new dog();
                mydog.name = "buddy";
                mydog.age = 3;
                mydog.bark();

                Console.WriteLine($"my dog name is{mydog.name} and he is {mydog.age} years old");
                Console.ReadKey();
            }
        }
    }
}
