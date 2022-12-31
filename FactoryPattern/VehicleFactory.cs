using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
   
       public Car CreateVehicle(string userVehicle)
        {
            switch (userVehicle.ToLower())
            {
                case "car":
                    Car myCar = new Car();
                    break;
                case "motorcycle":
                    Motorcycle myMotorcycle = new Motorcycle();
                    break;
                default:
                    break;
            }
        }



    }
}
