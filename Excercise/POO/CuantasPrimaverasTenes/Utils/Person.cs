using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantasPrimaverasTenes.Utils
{
    public class Person
    {
        public string Name { get; set; }
        public string DNI { get; set; }
        public DateTime DateBirth { get; set; }

        public Person(string name, string dNI, DateTime dateBirth)
        {
            Name = name;
            DNI = dNI;
            DateBirth = dateBirth;
        }

        private int CalculateAge()
        {
            return DateTime.Now.Year - DateBirth.Year;
        }

        public void IsLegalAge()
        {
            if(CalculateAge() >= 18)
            {
                Console.WriteLine($"{Name} es mayor de edad!({CalculateAge()})");
            }
            else
            {
                Console.WriteLine($"{Name} no es mayor de edad!({CalculateAge()})");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"-> Nombre: {Name}\n->DNI: {DNI}\n->Fecha de nacimiento: {DateBirth.ToString("dd/MM/yyyy")}\nEdad: {CalculateAge()}");
        }
    }
}
