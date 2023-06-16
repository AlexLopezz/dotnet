/*
Crear una aplicación de consola que permita al usuario ingresar un número entero.
Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
Mostrar en la consola el resultado.
Por ejemplo, si se ingresa el número 2 la salida deberá ser:
Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18
*/

using System.Text;
static string TableOf(int number)
{
    StringBuilder sb = new StringBuilder();
    for(var i= 1; i < 10; i++)
    {
        sb.Append(number).
           Append(" x ").
           Append(i).
           Append(" = ").
           Append(number*i).
           Append("\n");
    }

    return sb.ToString();
}

int number = 0;

//Leemos el numero para realizar la tabla correpondiente
Console.Write("Ingrese un numero: ");
number = int.Parse(Console.ReadLine());
Console.WriteLine($"Tabla de multiplicar del numero: {number}");
Console.WriteLine(TableOf(number)); //Mostramos la tabla

