using FleetSim.Objects.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects
{
    public class Vehicle
    {
        private int _mileage = 0;
        private int _lastServiceMileage = 0;
        private string _lastServiceDate;
        private Guid _vin;

        //Setting property for Vin
        public Guid Vin
        {
            get { return this._vin; }
            set { this._vin =  Guid.NewGuid(); }
        }

        //Setting property for Mileage
        public int Mileage
        {
            get { return _mileage; }
            set
            {
                _mileage = value;
                //TuneUp();
            }
        }
        //Property for LastServiceMileage
        public int LastServiceMileage
        {
            get { return _lastServiceMileage; }
            set { _lastServiceMileage = value;}
        }

        //Property for LastServiceDate
        public string LastServiceDate { get; set; }

        public void AddToMileage(int mileage) => Mileage += mileage;



        public void TuneUp(int mileage, int lastServiceMileage, string date, string modelname)
        {
            if ((Mileage - LastServiceMileage) >= 30000)
            {
                this.LastServiceMileage = mileage;
                LastServiceDate = DateTime.Now.ToString("M/d/yyyy hh:mm:ss");
                Console.WriteLine("Vehicle Tuned Up at" + " " + LastServiceMileage + " " + LastServiceDate);

            }
              if (Mileage >= 100000)
                ReBuildEngine(modelname);
        }

        public void ReBuildEngine(string model)
        {
            Mileage = 0;
            LastServiceMileage = 0;
            LastServiceDate = DateTime.Now.ToString("M/d/yyyy hh:mm:ss");
            Console.WriteLine("Engine ReBuilt on " + LastServiceDate +" " + "for" + " " + model );
        }

    }
}

