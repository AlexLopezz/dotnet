using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutoNavegacion.Utils
{
    public class Driver
    {
        public string Name { get; set; }
        public int[] KMTraveled { get; set; }

        public Driver(string name, int[] kMTraveled)
        {
            Name = name;
            KMTraveled = kMTraveled;
        }

        public int GetTotalKMInWeek()
        {
            int km = 0;
            foreach(var i in KMTraveled)
            {
                km += i;
            }

            return km;
        }

        public override string? ToString()
        {
            return $"* Nombre: {Name}\n* Kilometros totales recorrido en la semana: {GetTotalKMInWeek()}";
        }
    }
}
