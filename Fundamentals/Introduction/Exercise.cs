using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1
{
    internal class Exercise
    {
        static void Main(String[] args)
        {
            // Ejercicio 1: Escribe un programa que reciba tu nombre y lo escriba por consola.
            Console.Write("Ingrese su nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre}. Como estas?");

            // Ejercicio 2: Escribe un programa que tome la hora y la escriba por pantalla.
            String hora, minutos;
            Console.WriteLine("¿Que hora es?");
            Console.Write("Ingrese la hora que es(hh): ");
            hora = Console.ReadLine();
            Console.Write("Ingrese los minutos de la hora(mm): ");
            minutos = Console.ReadLine();
            Console.WriteLine($"La hora es: {hora}:{minutos}");
        }
    }
}
