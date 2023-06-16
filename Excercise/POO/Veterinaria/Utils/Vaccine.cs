using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Utils
{
    public class Vaccine
    {
        public string Name { get; set; }

        public Vaccine(string name)
        {
            Name = name;
        }

        public override string? ToString() => this.Name;
    }
}
