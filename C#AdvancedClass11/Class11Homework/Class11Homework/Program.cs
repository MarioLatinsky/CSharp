using Class11Homework;
using Newtonsoft.Json;

Dog userInput = new Dog();
Console.WriteLine("Please enter your dog's name: ");
userInput.Name = Console.ReadLine();

Console.WriteLine("Please enter your dog's Age:");
userInput.Age = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter your dog's Color:");
userInput.Color = Console.ReadLine();

string folderPath = "../../../MyData";
string filePath = folderPath + "/myFile.json";


if (!Directory.Exists(filePath))
{
    Directory.CreateDirectory(filePath);
}
if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}


void WriteToJson(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath))
    {
        sw.WriteLine(json);
    }
}

void ReadFromJson(string json)
{
    using(StreamReader sr = new StreamReader(json))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}



string dogSerialized = JsonConvert.SerializeObject(userInput);


WriteToJson(dogSerialized);
ReadFromJson(dogSerialized);