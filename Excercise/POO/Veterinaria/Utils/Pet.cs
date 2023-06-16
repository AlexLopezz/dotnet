using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Utils
{
    public class Pet
    {
        public string Species { get; set; }
        public string Nickname { get; set; }
        public DateTime DateBirth { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public Pet(string species, string nickname, DateTime dateBirth)
        {
            Species = species;
            Nickname = nickname;
            DateBirth = dateBirth;
            Vaccines = new List<Vaccine>();
        }

        public void AddVaccine(Vaccine vaccine) => this.Vaccines.Add(vaccine);

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("-> Apodo: ").Append(Nickname).Append("\n")
                .Append("-> Especie: ").Append(Species).Append("\n")
                .Append("-> Fecha de cumpleaños: ").Append(DateBirth.ToString("dd/MMMM/yyyy")).Append("\n");
            
            if(this.Vaccines.Count > 0)
            {
                Console.WriteLine("-> Vacunas: ");
                foreach (var vac in this.Vaccines)
                {
                    sb.Append(" *").Append(vac).Append("\n");
                }
            }

            return sb.ToString();
        }

        public override string? ToString() => this.Nickname;
    }
}
