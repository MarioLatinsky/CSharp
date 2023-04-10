
using Homework2.Enteties;

Car firstCar = new Car("Mercede", "GT63s", 700, true, true, false, true, false );

firstCar.CheckVehicle();
firstCar.Drive();
firstCar.WashCar();
firstCar.PumpGas();
firstCar.FixVehicle();

Console.WriteLine("\n");

Truck firstTruck = new Truck("Ford", "F150 Raptor", 450, true, false, false, false, true);

firstTruck.CheckVehicle();
firstTruck.Drive();
firstTruck.WashCar();
firstTruck.PumpGas();
firstTruck.FixVehicle();