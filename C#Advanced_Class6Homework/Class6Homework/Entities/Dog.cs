using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6Homework.Entities
{
    public class Dog : BaseEntity
    {
        public string Name { get; set; } = string.Empty;    
        public string Type { get; set; } = string.Empty;    

        public string Color { get; set; } = string.Empty;   

        public int Age { get; set; }

        public List<Dog> DogList { get; set;} = new List<Dog>();

        public Dog(string name, string type, string color, int age)
        {
            Name = name;
            Type = type;
            Color = color;
            Age = age;
        }

        public override void Print()
        {
            Console.WriteLine($"This is {Name} and he is a {Color} {Type}");
        }
    }
}
