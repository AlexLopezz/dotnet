/* Escribir un programa que determine si un año es bisiesto.
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
 * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
*/

//Creamos una funcion el cual retorno si realmente  un año es bisiesto.
bool IsLeapYear(int year)
{
    // Cuando se realizan sentencias de seleccion, es importante ir de lo mas alto a lo mas bajo.
    if (year % 400 == 0) //Por lo cual, si un año es divisible por 400, entonces es un año bisiesto.
    {
        return true;
    }else if(year % 4 == 0 && year % 100 != 0) //Si un año no es divisible por 400, pero... Es multiplo de 4 y no de 100 entonces tambien es bisiesto.
    {
        return true;
    }

    //Si el algoritmo, no determino el año bisiesto entonces.. Retornamos falso.
    return false;
}

// Declaramos e inicializamos los años de inicio y fin.
int baseYear = 0,
    stopYear = 0;

//Pedimos la data al usuario.
Console.WriteLine("Ingrese por favor el año de inicio: ");
baseYear = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese por favor el año de fin: ");
stopYear = int.Parse(Console.ReadLine());

// Tambien es importante que el año de inicio siempre sea menor que el año de fin... 
if (baseYear < stopYear)
{
    Console.WriteLine($"Año de inicio: {baseYear}");
    Console.WriteLine($"Año de fin: {stopYear}");

    Console.WriteLine("Estos son los años bisiestos entre esas fechas: ");
    for (var i = baseYear; i  <= stopYear; i++)
    {
        //SIempre y cuando sea bisiesto...
        if(IsLeapYear(i))
        {
            Console.WriteLine($"-> Año bisiesto encontrado: {i}"); // Mostramos.
        }
    }
}
else
{
    Console.WriteLine("El año de inicio, debe ser menor a el año de fin.");
}
