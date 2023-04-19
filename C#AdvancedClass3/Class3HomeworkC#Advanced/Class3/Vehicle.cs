using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Id: {Id}, Type: {Type}, Year of Production: {YearOfProduction}");
        }

    }
}
