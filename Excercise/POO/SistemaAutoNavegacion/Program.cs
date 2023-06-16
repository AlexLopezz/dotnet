/*
De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen cada día de la semana.
Para guardar esta información, la empresa de transporte tendrá un array de conductores.

De cada conductor se tendrá la siguiente información:
Nombre del conductor.
Kilometros recorridos por cada día de la semana. Por ejemplo:
Día 1: 200
Día 2: 599
Día 3: 899
Día 4: 0 (tiene franco)
Día 5: 256
Día 6: 0
Día 7: 0
Consigna
    * Desarrollar las clases y métodos necesarios. 
    * Toda la lógica de negocio deberá estar encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.

Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.

Luego mostrar:

El conductor que hizo más km en esa semana.
El conductor que hizo más km el día 3.
El conductor que hizo más km el día 5.
*/

using SistemaAutoNavegacion.Utils;

//Creamos los 3 conductores para luego agregar a la compañia: 
Driver[] drivers =
{
    new Driver(
        "Jorge Sequeira",
        new int[]
        {
            240,
            340,
            700,
            0,
            120,
            0,
            0
        }
    ),
    new Driver(
        "Mario Bofil",
        new int[]
        {
            540,
            640,
            100,
            0,
            220,
            0,
            0
        }
    ),
    new Driver(
        "Alan Bermudez",
        new int[]
        {
            140,
            740,
            700,
            900,
            0,
            0,
            0
        }
    )
};

//Instanciamos un objeto compañia, y le pasamos los conductores
TransportCompany myCompany = new(drivers);

//Obtenemos el conductor con mas recorrido en la semana:
Driver? driverMoreTravelWeek = myCompany.GetDriverMoreTravel();
Console.WriteLine($"--- CONDUCTOR CON MAS RECORRIDO ---");
Console.WriteLine(driverMoreTravelWeek);

//Obtenemos el conductor con mas recorrido en el dia 3:
int day = 3;
Driver? driverMoreTravelInDay = myCompany.GetDriverMoreTravel(day);
Console.WriteLine($"--- CONDUCTOR CON MAS RECORRIDO EN EL DIA: {day} ---");
Console.WriteLine($"Conductor: {driverMoreTravelInDay.Name}\nKM recorridos en el dia {day}: {driverMoreTravelInDay.KMTraveled[(day-1)]}");

//Lo mismo, pero esta vez con el dia 5:
day = 5;
driverMoreTravelInDay = myCompany.GetDriverMoreTravel(day);
Console.WriteLine($"--- CONDUCTOR CON MAS RECORRIDO EN EL DIA: {day} ---");
Console.WriteLine($"Conductor: {driverMoreTravelInDay.Name}\nKM recorridos en el dia {day}: {driverMoreTravelInDay.KMTraveled[(day-1)]}");