/*
El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los 
números enteros positivos que estén debajo de él.
    *Por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado. 
*/ 

//Realizamos una funcion recursiva para sacar el factorial del numero
static int FactorialOf(int number)
{
    if(number <= 1)  return number;
    else
        return number * FactorialOf(number - 1); //5 * factorial(4) -> 5 * 4 * fact(3) -> 5 * 4 * 3 * fact(2) -> 5 * 4 * 3 * 2 * fact(1) -> 5 * 4 * 3 * 2 * 1 = 120 
}

int number = 0;
//Obtenemos el numero.
Console.Write("Ingrese un numero entero positivo: ");
number = int.Parse(Console.ReadLine());


//Corroboramos que sea un numero positivo: 
if(number > 0)
{
    Console.WriteLine($"El factorial de {number} es: {FactorialOf(number)}"); //Calculamos el factorial de ese numero.
}
else
{
    Console.WriteLine("El factorial de un numero debe ser un entero positivo.");
}

