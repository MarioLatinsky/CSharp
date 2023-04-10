using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Enteties
{
    public abstract class Vehicle
    {


        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public bool IsDriven { get; set; }

        public bool IsClean { get; set; }

        public bool IsGasFull { get; set; }

        public bool IsBroken { get; set; }

        public bool IsChecked { get; set; }


        public Vehicle(string Make, string Model, int HorsePoweer, bool IsDriven, bool IsClean, bool IsGasFull, bool IsBroken, bool IsChecked ) {
        
        
            this.Make = Make;
            this.Model = Model;
            this.HorsePower = HorsePoweer;
            this.IsDriven = IsDriven;
            this.IsClean = IsClean;
            this.IsGasFull = IsGasFull;
            this.IsBroken = IsBroken;
            this.IsChecked = IsChecked;


        
        }


        public abstract void Drive();

        
      
    }
}
