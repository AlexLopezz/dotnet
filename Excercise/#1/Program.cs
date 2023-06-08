/* Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. */

// Guardaremos en esta vector, los 5 numeros que nos pide la consigna.
int[] numbers = new int[5];

// Declaramos e inicializamos variables que nos serviran para determinar:
int largest = 0, //El numero mayor.
    smaller = 0, //El numero menor 
    average = 0, //El promedio de la cantidad de numeros ingresados.
    quantity = 0; //La suma de todo esos numeros, para luego determinar el promedio.



for (var i = 0; i< numbers.Length; i++)
{
    Console.Write($"{(i+1)} Ingrese un numero: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

// Importante inicializar las variables mayor y menor, con el primer numero del vector, todo esto para luego comparar dentro de una iteracion.
largest = numbers[0]; 
smaller = numbers[0];

for (var i = 0; i < numbers.Length; i++)
{
    //Vamos comparando por cada numero para ver si es mayor o menor de la primer variable asignada.
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }else if (numbers[i] < smaller)
    {
        smaller = numbers[i];
    }
   
    quantity += numbers[i]; // Es importante dentro del for, sumar todos los numeros ingresados.
}
//Calculamos el promedio, que es basicamente la suma de todos los numeros, dividido la cantidad de numeros ingresados.
average = quantity / numbers.Length;

Console.WriteLine($"Numero mayor: {largest}");
Console.WriteLine($"Numero menor: {smaller}");
Console.WriteLine($"Promedio: {average}");




