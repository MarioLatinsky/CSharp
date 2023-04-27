

using HomeworkClass4;
using HomeworkClass4.Entities;


AmericanCar ford = new AmericanCar()
{
    Id = 1,
    Brand = "Ford",
    Model = "GT",
    MaxSpeed = 275,
    HorsePower = 400,
    FuelType = "Petrol"
};

FrenchCar peugeot = new FrenchCar()
{
    Id = 2,
    Brand = "Peugeot",
    Model = "205 GTI",
    MaxSpeed = 230,
    HorsePower = 150,
    FuelType = "Petrol"
};

GermanCar BMW = new GermanCar()
{
    Id = 3,
    Brand = "BMW",
    Model = "E60 M5",
    MaxSpeed = 310,
    HorsePower = 507,
    FuelType = "Petrol"
};

JapaneseCar nissan = new JapaneseCar()
{
    Id = 4,
    Brand = "Nissan",
    Model = "R35 GT-R",
    MaxSpeed = 330,
    HorsePower = 600,
    FuelType = "Petrol"
};

GenericDB<AmericanCar>.Insert(ford);
GenericDB<FrenchCar>.Insert(peugeot);
GenericDB<GermanCar>.Insert(BMW);
GenericDB<JapaneseCar>.Insert(nissan);

string text = "These are all the cars";

text.ColorText(ConsoleColor.Green);