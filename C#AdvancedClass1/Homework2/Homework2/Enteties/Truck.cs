using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Enteties
{


    public class Truck : Vehicle, ICarWash, IGasPump, IRepairService
    {



        public Truck(string Make, string Model, int HorsePower, bool IsClean, bool IsGasFull, bool IsBroken, bool IsDriven, bool IsChecked) : base (Make, Model, HorsePower, IsClean, IsGasFull, IsBroken, IsDriven, IsChecked)
        {
           
        }

        public override void Drive()
        {
            switch (IsDriven)
            {
                case true:
                    Console.WriteLine($"Your {Make} is being driven");
                    break;

                case false:
                    Console.WriteLine($"Your {Make} is parked or crashed.");
                    break;
            }



        }
        public void WashTrailer()
        {
            switch (IsClean)
            {
                case true:
                    Console.WriteLine($"Your {Make} is clean, take it for a spin.");
                    break;

                case false:
                    Console.WriteLine($"Your {Make} is dirty as hell, clean the damn thing.");
                    break;
            }
        }


        public void PumpGas()
        {

            switch (IsGasFull)
            {
                case true:
                    Console.WriteLine($"Your {Make} has enough gas, don't worry about it.");
                    break;

                case false:
                    Console.WriteLine($"You might wanna go to a gas station ASAP.");
                    break;
            }

        }


        public void CheckVehicle()
        {

            switch (IsChecked)
            {
                case true:
                    Console.WriteLine($"Your {Make} is being cheked by a mechanic.");
                    break;

                case false:
                    Console.WriteLine($"Your {Make} might need maintenance");
                    break;
            }

        }


        public void FixVehicle()
        {

            switch (IsBroken)
            {
                case true:
                    Console.WriteLine($"*Rod bearing knocking noise* get your {Make} to a mechanic. ");
                    break;

                case false:
                    Console.WriteLine($"Your {Make} is running nice and smooth ");
                    break;


            }

        }


        public void WashCar()
        {
        }
    }
}
