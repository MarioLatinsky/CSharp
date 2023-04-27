using Class6Homework;
using Class6Homework.Entities;
using System.Collections.Generic;

//1

//List<Person> NameStartingWithR = (List<Person>)Db.people.Where(x => x.FirstName.StartsWith('R')).OrderByDescending(x => x.Age).ToList();

////NameStartingWithR.PrintEntities();

////2
//List<Dog> AllBrownDogsOlderThanThree = (List<Dog>)Db.dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).ToList();
////AllBrownDogsOlderThanThree.PrintEntities();

////3
//List<Person> PeopleWithMoreThanTwoDogs = (List<Person>)Db.people.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();

//PeopleWithMoreThanTwoDogs.PrintEntities();
//PeopleWithMoreThanTwoDogs.PrintItems();

List<Person> FreddysDogs = (List<Person>)Db.people.Where(x => x.FirstName == "Freddy").SelectMany(x => x.Dogs)
                                                                                      .Where(x => x.Age > 1)
                                                                                      .Select(x => x.Name);

foreach (Person dog in FreddysDogs  )
{
    Console.WriteLine(dog.FirstName);
}