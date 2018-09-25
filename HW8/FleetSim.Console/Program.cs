using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Class;
using FleetSim.Objects.ENUM;
using FleetSim.Objects.Interface;

namespace FleetSimConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {            
            
            List<Car> cars = new List<Car>()
            {
                // Car(string model,int mileage,int lastservicemileage, carColor color)
                new Car("Mustang",0,0, carColor.Red),
                new Car("Taurus",0,0, carColor.Blue),
                new Car("Explorer",0,0, carColor.White),
                new Car("Altima",0,0, carColor.Blue),
                new Car("Lancer",0,0, carColor.Red)
            };

            try
            {
                foreach (var car in cars)
                {
                    for (int counter = 0; counter < 10; counter++)
                    {
                        Random random = new Random();
                        int RndMileage = random.Next(5000, 15000);
                        car.Mileage += RndMileage;
                        car.TuneUp(car.Mileage, car.LastServiceMileage, car.LastServiceDate, car.Model);
                    }
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception Caught!");
            }
            
        }
    }
}
