﻿using System;
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




        public Vehicle(string Make, string Model, int HorsePoweer) {
        
        
            this.Make = Make;
            this.Model = Model;
            this.HorsePower = HorsePoweer;


        
        }


        public abstract void Drive();
      
    }
}
