﻿/*
En un proyecto de biblioteca de clases, crear la clase Boligrafo a partir del siguiente diagrama:

Diagrama de clases
    * La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante cantidadTintaMaxima en Boligrafo donde se guardará dicho valor.
    * Generar los métodos getter GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor de los mismos).
    * Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, modifique el valor del atributo tinta.
    * El argumento tinta contedrá la cantidad de tinta a agregar o quitar. Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
    * Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima. Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
    * El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
    * El método Pintar restará la tinta gastada (reutilizar código). El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta como tenga disponible sin quedar en negativo. Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, por ejemplo:
    * Si no había nada de tinta retornará una cadena de texto vacía.
        *Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
        *Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
    
    En el main:
    * Agregar un proyecto de consola.
    * En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
    * Utilizar todos los métodos y mostrar los resultados por consola.
    * Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
*/

using InventoArgentino.Utils;
//Estas variables serviran para su posterior cuando dibujamos los '*'
string drawBlue = "",
       drawRed = "";

//Creamos los boligrafos
BallPoint ballPointBlue = new BallPoint(100, ConsoleColor.Blue);
BallPoint ballPointRed = new BallPoint(50, ConsoleColor.Red);

//Mostramos una informacion general
Console.WriteLine(ballPointBlue.ShowInfo());
Console.WriteLine(ballPointRed.ShowInfo());

//Modificamos el color de consola
Console.ForegroundColor = ballPointBlue.GetColour();
ballPointBlue.Paint(90, out drawBlue); //Pintamos
Console.WriteLine(drawBlue); //Mostramos
ballPointBlue.Paint(50, out drawBlue); //Pintamos de vuelta, solamente va pintar hasta que se quede sin tinta, mas de eso no.
Console.WriteLine(drawBlue);
Console.WriteLine($"Nivel de tinta azul: {ballPointBlue.GetINK()}"); //Mostramos el nivel de tinta

//Modificamos el color de consola
Console.ForegroundColor = ballPointRed.GetColour();
ballPointRed.Paint(50, out drawRed); //Pintamos hasta quedar sin tinta
Console.WriteLine(drawRed);
Console.WriteLine($"Nivel de tinta rojo: {ballPointRed.GetINK()}"); //Quedamos sin tinta

Console.ForegroundColor = ConsoleColor.White; //Volvemos a la normalidad

//Recargamos los boligrafos
ballPointBlue.Reload();
ballPointRed.Reload();

//Mostramos de vuelta informacion general de los boligrafos, demostrando de que si funciona el metodo Reload() y demas metodos.
Console.WriteLine(ballPointBlue.ShowInfo());
Console.WriteLine(ballPointRed.ShowInfo());

