/*
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.
Diagrama de clase Sumador

Crear dos constructores:

    * Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
    * Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
    * El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con
      la siguiente lógica:

        * En el caso de Sumar(long, long) sumará los valores numéricos
        * En el de Sumar(string, string) concatenará las cadenas de texto.

Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.
Seguido:

    * Generar una conversión explícita que retorne cantidadSumas.
    * Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
    * Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
      Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
*/

using Sumador.Utils;

Adder adder = new Adder(1);

//Verificamos si funciona el metodo Add que debe retorna la suma en long.
var result = adder.Add(23,43);
Console.WriteLine(result); 
Console.WriteLine(adder.CountAdd); //Al realizar un Add se incrementa a uno el contador.

//Verificamos si funciona el metodo Add que debe retorna la concatenacion de dos string
var resultStr = adder.Add("Mi nombre es: ", "Alex Lopez");
Console.WriteLine(resultStr);
Console.WriteLine(adder.CountAdd); //Al realizar un Add se incrementa a uno el contador.

//Creamos un nuevo objeto sumador:
Adder adder2 = new Adder(1);

//Sumamos los dos tipos Sumador para ver si funciona la sobrecarga del operador suma (+) 
var addAder = adder + adder2;

//Realizamos una conversion explicita a int del tipo sumador, para verificar si funciona la sobrecarga
Console.WriteLine((int)adder);

//Realizamos un or unario, para ver si funciona la sobrecarga que realizamos.
Console.WriteLine(adder | adder2); //Dara False.
adder2.CountAdd+= 2;
Console.WriteLine(adder | adder2); //Dara True.