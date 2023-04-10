using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Enteties
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking your vehicle");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing your vehicle");
        }

        public void PumpGas()
        {
            Console.WriteLine("Pumping gas for every vehicle");
        }

        public void WashCar()
        {
            Console.WriteLine("Washing cars");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing trailers");
        }



    }
}
