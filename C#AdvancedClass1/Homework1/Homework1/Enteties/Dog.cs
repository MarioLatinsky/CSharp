using Homework1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Enteties
{
    public class Dog : Animal, IDog
    {

        public bool HatesCats { get; set; }


        public Dog(string Type, string Name, int Age, bool HatesCats) : base(Type, Name, Age)
        {
            this.HatesCats = HatesCats;
        }
        public void Bark()
        {
            Console.WriteLine($"The {Type} named {Name} is barking at you!");
        }

        
        



    }
}
