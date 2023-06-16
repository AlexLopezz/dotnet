/* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.
 */ 

//Vamos abstraer el codigo por partes. Primero realizaremos una funcion que nos determine si un numero es perfecto.
bool IsPerfectNumber(int number)
{
    int suma = 0;
    for (var i = 1; i < number; i++)
    {
        //Si i es divisor de el numero, entonces vamos sumando...
        if (number % i == 0) suma += i;

        if (suma > number) return false; //Si la suma, en algun momento es mas grande que el numero, entonces directamente retornamos falso.
    }

    return (suma == number); //Una vez terminada la iteracion, entonces... verificaremos si la suma de divisores del numero es igual al numero.
}

//Desde aqui, empezaria nuestro main.
int countPerfectNumber = 0,
    iterator = 1;

//Este ciclo iterara hasta que se encuentren los 4 primeros numeros perfectos.
while(countPerfectNumber <= 4)
{
    if (IsPerfectNumber(iterator)) //Si el numero es perfecto(es decir si a true)
    {
        countPerfectNumber++; //Aumentamos la cantidad de numeros perfecto a uno.
        Console.WriteLine($"Se encontro un numero perfecto: {iterator}({countPerfectNumber})"); //Mostramos por pantalla.
    }
    iterator++;
}