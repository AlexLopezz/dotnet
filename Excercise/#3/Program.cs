/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

 * Validar que el dato ingresado por el usuario sea un número.
 * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
 * Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
*/

// Primero... ¿Que es un numero primo? Es aquel numero que es divisible entre uno, y por si mismo.

int     number = 0;
string  choice = "",
        msgError = "Error, debe ingresar un valor valido.";
bool    follow = true;
//Aqui es importante abstraer codigo mediante funciones. Primero realizaremos una funcion para determinar si el numero es primo:
bool IsCousin(int number)
{
    if (number >= 2)
    {
        for (var i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    else return false;


}

//Este while, formara parte de nuestro main.
while (follow)
{
    //Este try, es mas que nada para prevenir excepciones, si ingresa un string no numerico. 
    try
    {
        Console.Write("Ingrese un numero: ");
        number = int.Parse(Console.ReadLine()); //Si parseamos el string y no tiene numeros, arrojara error.

        Console.WriteLine($"Numeros primos, hasta el numero: {number}");
        for (var i = 0; i < number; i++)
        {
            if (IsCousin(i)) Console.WriteLine($"N° {i}"); //Si es primo, imprimimos por pantalla.
        }

        Console.Write(@"¿Desea volver a ingresar un numero?
        *Si asi lo desea, ingrese cualquier tecla.
        *De lo contrario, escriba 'salir'.
        Respuesta: ");

        choice = Console.ReadLine(); //Leemos la respuesta del usuario... 

        if (choice.Equals("salir")) break; // Si es igual a 'salir', no tiene sentido volver a iterar, por lo tanto salimos del bucle.
        else Console.Clear(); //De lo contrario, seguimos iterando, pero no sin antes, limpiar la consola.
    }
    catch(Exception) //Aqui campturaremos el error, si a la hora de parsear el numero ingresado nos lanza un error.
    {
        Console.WriteLine(msgError);
    }
}