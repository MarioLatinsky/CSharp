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



        bool isDriven { get; set; }
        bool isClean { get; set; }

        bool isGasFull { get; set; }

        bool isBroken { get; set; }

        bool isChecked { get; set; }
        public Truck(string Make, string Model, int HorsePower, bool isClean, bool isGasFull, bool isBroken, bool isDriven, bool isChecked) : base(Make, Model, HorsePower)
        {
            this.isDriven = isDriven;
            this.isClean = isClean;
            this.isGasFull = isGasFull;
            this.isBroken = isBroken;
            this.isChecked = isChecked;

        }
        public void WashCar()
        {

           

        }

    

        public override void Drive()
        {
            switch (isDriven)
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
            switch (isClean)
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

            switch (isGasFull)
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

            switch (isChecked)
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

            switch (isBroken)
            {
                case true:
                    Console.WriteLine($"*Rod bearing knocking noise* get your {Make} to a mechanic. ");
                    break;

                case false:
                    Console.WriteLine($"Your {Make} is running nice and smooth ");
                    break;


            }

        }
    }
}
