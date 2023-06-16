using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutoNavegacion.Utils
{
    public class TransportCompany
    {
        public Driver[] TransportDriver { get; set; }

        public TransportCompany(Driver[] drivers)
        {
            TransportDriver = drivers;
        }

        public Driver? GetDriverMoreTravel()
        {
            Driver driverMoreTravel = new();
      
            for (var i = 0; i < TransportDriver.Length; i++)
            {
                if (i == 0)
                {
                    driverMoreTravel = TransportDriver[i];
                }
                else if (TransportDriver[i].GetTotalKMInWeek() > driverMoreTravel.GetTotalKMInWeek())
                {
                    driverMoreTravel = TransportDriver[i];
                }
            }
            return driverMoreTravel;
        }
        public Driver? GetDriverMoreTravel(int day)
        {
            Driver driverMoreTravel = new();
            if(day >= 0 && day < 7)
            {
                int major = 0;
                day -= 1; //Debido a que el arreglo toma en cuenta como primer posicion el 0.
                foreach(var driver in TransportDriver) 
                {
                    if (driver.KMTraveled[day] > major) {
                        major = driver.KMTraveled[day];
                        driverMoreTravel = driver;
                    }
                }                
            }
            return driverMoreTravel;
        }
    }
}
