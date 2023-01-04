using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
   
        public static IVehicle CreateVehicle(string userVehicle)
        {
            switch (userVehicle.ToLower())
            {
                case "car":
                    Car myCar = new Car();
                    return new Car();
                case "motorcycle":
                    Motorcycle myMotorcycle = new Motorcycle();
                    return new Motorcycle();
                default:
                    throw new ArgumentException();
            }
        }



    }
}
