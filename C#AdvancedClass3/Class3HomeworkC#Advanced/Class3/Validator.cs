using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    public class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            return vehicle.Id != 0 && !string.IsNullOrEmpty(vehicle.Type) && vehicle.YearOfProduction != 0;
        }
    }
}
