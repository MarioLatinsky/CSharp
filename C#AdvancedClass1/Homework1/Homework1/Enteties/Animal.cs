using Homework1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Enteties
{
    public abstract class Animal : IAnimal
    {
        public void printAnimal(string Type, string Name, int Age)
        {

            Console.WriteLine($"The {Type} is called {Name} and is {Age} old.");

        }


        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Animal(string Type, string Name, int Age)

        {
            this.Type = Type;
            this.Name = Name;
            this.Age = Age;

        }

    }
}
