/* Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!"
 */

// Declaramos las variables a utilizar.
double  number = 0, //El numero el cual operaremos para verificar el cuadrado y el cubo.
        square = 0, //Elevar un número al cuadrado es multiplicarlo por sí mismo(u dos veces).
        cube   = 0; //Elevar un número al cubo es multiplicar ese número 3 veces:

bool follow = true; // Un booleano el cual nos servira para verificar si el usuario quiere(o no) seguir calculando el cuadrado y cubo de un numero.

while (follow)
{
    //Leemos el numero.
    Console.Write("Ingrese un numero: ");
    number = int.Parse(Console.ReadLine());

    // Calcularemos el cuadrado y cubo solo si el numero ingresado es mayor a 0.
    if(number > 0)
    {
        // La potencia con exponente lo realizaremos con la libreria Math especificamente el metodo Pow(): https://www.geeksforgeeks.org/c-sharp-math-pow-method/
        square = Math.Pow(number, 2); // o de otra forma: number * number;
        cube    = Math.Pow(number, 3); // de otra forma: number * 3;
        Console.WriteLine($"El cuadrado de ese numero es: {square}");
        Console.WriteLine($"El cubo de ese numero es: {cube}");

        Console.Write("Si desea volver a ingresar otro numero, presione la tecla S\nRespuesta: ");
        ConsoleKeyInfo input = Console.ReadKey(true);

        //Evaluamos la letra que indico el usuario: 
        if (!(input.KeyChar == 's' || input.KeyChar == 'S')) // Si es diferente de S, entonces paramos el ciclo while.
        {
            follow = false; // Al declarar follow como falso, el ciclo dejara de iterar.
        }
        else
        {
            Console.Clear(); // Sino, significa que digito la tecla s u S, por lo tanto seguimo iterando, pero no sin antes limpiar la consola.
        }
    }
    else
    {
        Console.WriteLine("Error. ¡Reingresar numero!"); //Si el numero ingresado es menor a 0 , entonces indicamos el error.
    }
}
