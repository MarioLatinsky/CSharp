using Homework1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Enteties
{
    public class Cat : Animal, ICat

    {
        public bool LikesToEatFish { get; set; }

        public void Eat(string food)
        {
            Console.WriteLine($"The {Type} named {Name} is eating {food}");
        }



        public Cat(string Type, string Name, int Age, bool likesToEatFish) : base(Type, Name, Age)
        {
            LikesToEatFish = likesToEatFish;
        }
    }
}
