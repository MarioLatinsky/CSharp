using Class3.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    public static class DataBase
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>
    {
        new Vehicle { Id = 1, Type = "Vehicle 1", YearOfProduction = 2021, BatchNumber = 1 },
        new Car { Id = 2, Type = "Car 1", YearOfProduction = 2022, BatchNumber = 2, FuelTank = 50, Countries = "Italy" },
        new Bike { Id = 3, Type = "Bike 1", YearOfProduction = 2023, BatchNumber = 3, Color = "Red" }
    };

    }


}


