using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class6Homework.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string LastName { get; set; } = string.Empty;
        public  List<Dog> Dogs { get; set; }

        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Dogs = new List<Dog>(); 
            
        }
       
        public override void Print()
        {
            Console.WriteLine($"This is {FirstName} {LastName} and is a proud owner of {Dogs.Count} dogs");

        }
    }
}
