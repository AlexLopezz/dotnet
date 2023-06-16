/*
Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual.
Tener en cuenta los años bisiestos.
Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona
hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
*/

static int PastDays(DateTime date) => (int)DateTime.Now.Subtract(date).TotalDays;

int day = 0,
    month = 0,
    year = 0;


Console.Write("Dia de nacimiento: ");
day = int.Parse(Console.ReadLine());
Console.Write("Mes de nacimiento: ");
month = int.Parse(Console.ReadLine());
Console.Write("Año de nacimiento: ");
year = int.Parse(Console.ReadLine());

int days = PastDays(new DateTime(year, month, day));

Console.WriteLine($"Desde el año {year} hasta la actualidad({DateTime.Now.Year}) pasaron un total de {days} dias.");


