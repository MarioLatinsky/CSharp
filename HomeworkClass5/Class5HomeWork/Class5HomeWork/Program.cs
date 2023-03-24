//exercise 3

using Class5HomeWork.Models;

Student[] StudentArr = new Student[6];

StudentArr[0] = new Student();
StudentArr[0].Name = "John";
StudentArr[0].Academy = "SEDC";
StudentArr[0].Group = "G2";


StudentArr[1] = new Student();
StudentArr[1].Name = "Michael";
StudentArr[1].Academy = "SEDC";
StudentArr[1].Group = "G2";


StudentArr[2] = new Student();
StudentArr[2].Name = "Victoria";
StudentArr[2].Academy = "SEDC";
StudentArr[2].Group = "G2";


StudentArr[3] = new Student();
StudentArr[3].Name = "Zack";
StudentArr[3].Academy = "SEDC";
StudentArr[3].Group = "G1";



StudentArr[4] = new Student();
StudentArr[4].Name = "Lilly";
StudentArr[4].Academy = "SEDC";
StudentArr[4].Group = "G2";


StudentArr[5] = new Student();
StudentArr[5].Name = "Bob";
StudentArr[5].Academy = "SEDC";
StudentArr[5].Group = "G1";


Console.WriteLine("Please enter a Student's name: ");
string userInput = Convert.ToString(Console.ReadLine());
bool found = false;




for(int i = 0; i < StudentArr.Length; i++)
{


    if (userInput == StudentArr[i].Name)
    {

        Console.WriteLine($"{StudentArr[i].Name} is from {StudentArr[i].Academy} Academy and from the Group: R{StudentArr[i].Group}");
        found = true;   
        break;

    }
   
}



if (!found)
{
    Console.WriteLine("Error, no such student found");
}








