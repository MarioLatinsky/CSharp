using Class6Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6Homework
{
    public static class Db
    {
        public static List<Person> people = new List<Person>()
        {
            new Person("Cristofer", "Wayne", 35),
            new Person("Freddy", "Coleman", 26),
            new Person("Erin", "Elsonbaty", 19),
            new Person("Amelia", "Cuttler", 46),
            new Person("Nathen", "Priest", 31)
        };

        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog("Bruce", "American Pitbull", "Brown", 4),
            new Dog("Ronnie", "Mastiff" , "Black", 5),
            new Dog("Nasser", "Boxer", "Brown", 6),
            new Dog("Jay", "German Shepard", "Black", 6),
            new Dog("Lee", "Husky", "Grey", 8),
            new Dog("Arnold", "Doberman", "Brown", 7)
        };
        static Db ()
        {
            people[0].Dogs = new List<Dog>() { dogs[0], dogs[5], dogs[2] };
            people[1].Dogs = new List<Dog>() { dogs[1], dogs[2], dogs[3] };
            people[2].Dogs = new List<Dog>() { dogs[5], dogs[1] };
            people[3].Dogs = new List<Dog>() { dogs[0], dogs[2], dogs[5] };
            people[4].Dogs = new List<Dog>() { dogs[4], dogs[3] };

        }


    }
}
