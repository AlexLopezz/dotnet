using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Utils
{
    public class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public List<Pet> Pets { get; set; }

        public Client(string name, string lastName, string address)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            Pets = new List<Pet>();
        }

        public void AddPet(Pet pet) => this.Pets.Add(pet);

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("-> Nombre: ").Append(Name).Append("\n")
                .Append("-> Apellido: ").Append(LastName).Append("\n")
                .Append("-> Domicilio: ").Append(Address).Append("\n");

            if(Pets.Count > 0)
            {
                sb.Append("--- MASCOTAS ---").Append("\n");
                foreach(Pet pet in Pets)
                {
                    sb.Append(" *").Append(pet).Append("\n");
                }
            }

            return sb.ToString();
        }
    }
}
