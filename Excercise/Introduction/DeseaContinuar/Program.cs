/*
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. 
*/

using DeseaContinuar;

int add = 0; //Con esta variable almacenaremos la suma de numeros.
bool follow = true; //Esta variable, determinara si se sigue ejecutando la suma o no.


while (follow)
{
    //Informamos la suma actual: 
    Console.WriteLine($"-> Suma actual: {add}");
    try
    {
        Console.Write("Ingrese numero: ");
        add += int.Parse(Console.ReadLine());

        Console.WriteLine("¿Desea continuar? (S/N)");
        follow = Validator.ValidAnswer(Console.ReadKey(true).KeyChar); //Enviamos por parametro la tecla que toco, para verificar si quiere seguir o no.
    }
    catch (FormatException) //Capturamos excepcion si ingresa cualquier cosa que no sea un numero.
    {
        Console.WriteLine("Numero no valido.");
    }
}