/*
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
    bool Validar(int valor, int min, int max)
    * valor: dato a validar.
    * min: mínimo valor incluido.
    * max: máximo valor incluido.
   
Pedir al usuario que ingrese 10 números enteros. 
Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
*/

//Variables a utilizar: 
int minR = 0, //Almacenara el valor minimo del rango
    maxR = 0, //Almacenara el valor maximo del rango
    min = 0, // Almacenara el minimo valor numerico almacenado
    max = 0, //ALmacenara el maximo valor numerico almacenado
    add = 0, //Sumara todos los numeros para su posterior uso en el calculo del promedio.
    average = 0; //Promedio de los 10 numeros ingresados

bool isMin = false; // Servira como bandera/flag para verificar si el numero es menor al mayor del rango.


while (!isMin)
{
    try
    {
        //Almacenamos los valores minimos y maximos del rango.
        Console.Write("Ingrese el valor MINIMO: ");
        minR = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor MAXIMO: ");
        maxR = int.Parse(Console.ReadLine());

        //Verificamos que minimo sea menor que el maximo ingresado
        if(minR < maxR)
        {
            if(minR >= -100 && maxR <= 100)
            {
                isMin = true;
            }
            else
            {
                Console.WriteLine("El valor minimo no debe ser mayor a -100.\nEl valor maximo no debe ser mayor a 100.");
            }
        }
        else
        {
            Console.WriteLine("[X] El valor identificado como MINIMO debe ser MENOR que el valor identificado como MAYOR.");
        }
    }
    catch (Exception) //Capturamos excepcion si ingresa otra cosa que no sea un numero.
    {
        Console.WriteLine("Ingrese por favor valores validos.");
    }
}

for (var i = 0; i < 10; i++)
{
    bool isValid = false; //Se utilizara como bandera, para verificar si un numero es valido(si esta entre el rango definido anteriormente)
    while (!isValid)
    {
        int auxNumber = 0; //Se utilizara como numero auxiliar para leer el numero que el usuario ingresa

        Console.Write($"Ingresa un numero ({(i+1)}): ");
        auxNumber = int.Parse(Console.ReadLine());

        if(!Validator.ValidValue(auxNumber, minR, maxR)) //Si no es valido, entonces informamos... No saldra del bucle hasta que se ingrese un numero valido.
        {
            Console.WriteLine($"[X]Numero: {auxNumber} NO VALIDO!\n-> Debe ser mayor/igual a {minR} y menor/igual a {maxR}");
        }
        else
        {
            //Como primera instancia, inicializamos min y max con el primer numero ingresado en la primer iteracion...
            if (i == 0)
            {
                min = auxNumber;
                max = auxNumber;
            }
            //Desde la segunda iteracion verificaremos si es mayor o menor
            else if (auxNumber > max) 
            {
                max = auxNumber;
            }else if(auxNumber < min)
            {
                min = auxNumber;
            }
            //Vamos sumando todos los numeros ingresados para luego sacar el promedio.
            add += auxNumber;
            isValid = true; //Damos el OK para la siguiente iteracion.
        }
    }
}
average = add / 10; //Calculamos el promedio.
//Informamos
Console.WriteLine($"-> Minimo: {min}\n-> Maximo: {max}\n-> Promedio: {average}");



