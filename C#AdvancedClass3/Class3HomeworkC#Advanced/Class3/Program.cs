

using Class3;
using Class3.Enteties;
static void Main(string[] args)
{
    foreach (var vehicle in DataBase.Vehicles)
    {
        vehicle.PrintVehicle();
    }

    Console.WriteLine("\nValidation Results:");
    Console.WriteLine($"Vehicle 1: {Validator.Validate(DataBase.Vehicles[0])}");
    Console.WriteLine($"Car 1: {Validator.Validate(DataBase.Vehicles[1])}");
    Console.WriteLine($"Bike 1: {Validator.Validate(DataBase.Vehicles[2])}");
}