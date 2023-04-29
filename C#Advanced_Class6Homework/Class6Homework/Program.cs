using Class6Homework;
using Class6Homework.Entities;

//1

List<Person> NameStartingWithR = (List<Person>)Db.people.Where(x => x.FirstName.StartsWith('R')).OrderByDescending(x => x.Age).ToList();

//NameStartingWithR.PrintEntities();

//2
List<Dog> AllBrownDogsOlderThanThree = (List<Dog>)Db.dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).ToList();
//AllBrownDogsOlderThanThree.PrintEntities();

//3
List<Person> PeopleWithMoreThanTwoDogs = (List<Person>)Db.people.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();

//PeopleWithMoreThanTwoDogs.PrintEntities();
//PeopleWithMoreThanTwoDogs.PrintItems();

//4
var FreddysDogs = Db.people.Where(x => x.FirstName == "Freddy").SelectMany(x => x.Dogs).Where(x => x.Age > 1).Select(x => x.Name);
Console.WriteLine("Freddy's dogs older than 1 year:");
//foreach (var name in FreddysDogs)
//{
//    Console.WriteLine(name);
//}

//5
var NathensDog = Db.people.Where(x => x.FirstName == "Nathen").Select(x => x.Dogs.FirstOrDefault());
Console.WriteLine("Nathen's first dog:");
//foreach (var dog in NathensDog)
//{
//    if (dog != null)
//    {
//        Console.WriteLine(dog.Name);
//    }
//    else
//    {
//        Console.WriteLine("No dog found");
//    }

//}


//6
var whiteDogs = Db.people.Where(x => x.FirstName == "Cristofer" ||
                                           x.FirstName == "Freddy" ||
                                           x.FirstName == "Erin" ||
                                           x.FirstName == "Amelia" ||
                                           x.FirstName == "Nathen")
                              .SelectMany(x => x.Dogs)
                              .Where(x => x.Color == "white")
                              .OrderBy(x => x.Name)
                              .Select(x => x.Name);

//if (!whiteDogs.Any())
//{
//    Console.WriteLine("No white dogs found.");
//}
//else
//{
//    foreach (var dogName in whiteDogs)
//    {
//        Console.WriteLine(dogName);
//    }
//}