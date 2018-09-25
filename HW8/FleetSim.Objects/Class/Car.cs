using FleetSim.Objects.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  FleetSim.Objects.Class;
using FleetSim.Objects.ENUM;

namespace FleetSim.Objects.Class
{
    public class Car : Vehicle
    {
        
        public int Year { get; set; }

        public string Make { get; set; }
        
        public string Model { get; set; }
        private  carColor _color;

        public Car()
        {
        }
        // added for efficiency....for using Collectoion of vehicles
        public Car(string model,int mileage,int lastservicemileage, carColor color)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.LastServiceMileage = lastservicemileage;
            this._color = color;

        }
        //Overload Constructor
        public Car(int year,string make, string model)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
        }
        //Overload Constructor
        public Car (int year, string make,string model, carColor color)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this._color = color;
        }

    }
    
}
