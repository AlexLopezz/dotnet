/* 
Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
 * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
 * El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

 */


int stop = 0, // Esta variable nos servira para indicar el tope (que sera el numero que indica el usuario) para buscar centros numericos.
    sumBefore = 0, // Esta variable servira para sumar todos los elementos antes del iterador actual.
    sumAfter = 0; //Esta variable servira para sumar todos los elementos despues del iterador actual.

//Leemos el tope
Console.Write("Ingrese un numero: ");
stop = int.Parse(Console.ReadLine());

// FOR anidado, el primer for servira para ir sumando antes del iterador actual. 
for (var i = 1; i <= stop; i++)
{
    sumBefore += (i-1);
    for (var j = (i + 1); j <= stop; j++) // El segundo for servira para ir sumando despues del iterador actual.
    {
        sumAfter += j;
        if (sumBefore == sumAfter) // Si coincide significa que la suma antes del iterador y despues, coinciden. por lo cual encontramos un centro numerico.
        {
            Console.WriteLine($"-> Se encontro centro numerico: {i}");
        }
    }
    sumAfter = 0; //Reseteamos la suma despues del iterador.
}