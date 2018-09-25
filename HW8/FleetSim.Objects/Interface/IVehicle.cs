using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects.Interface
{
    public interface IVehicle
    {
        void TuneUp(int mileage, int lastServiceMileage, string date, string modelname);
        void ReBuildEngine(string modelname);
    }
}