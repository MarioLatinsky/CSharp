using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass4.Entities
{
    public class GermanCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"This car is driving to {destinationName}");
        }
    }
}
