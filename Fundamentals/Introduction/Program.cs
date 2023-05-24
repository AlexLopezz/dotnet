//Estamos en .NET 7 por lo que, en esta version... Se utiliza una version minimalista, es decir sin el tipico 'main(String[] args). (Desde .NET6 en adelante)

//Forma de escribir por consola en CSharp. Cada linea escrita, debe terminar con punto y coma. ( ; )
Console.WriteLine("Hello, World!"); //Prueba con 'cw' para escribir el snipets para Console.Writeline();

Console.Write("Hola mundo!"); //Con Console.Write(); imprimimos por pantalla pero a diferencia de WriteLine(), este no salta la linea al final de la linea.


String nombre = "Alex";
// Concatenacion: 
Console.WriteLine("Mi nombre es "+nombre); //Se podria realizar de la forma tradicional
Console.WriteLine($"Mi nombre es {nombre}"); //Se podria realizar con interpolacion de cadenas. Mas info aqui: https://learn.microsoft.com/es-es/dotnet/csharp/tutorials/string-interpolation

//Forma de leer entradas desde consola en CSharp.
nombre = Console.ReadLine();
String ciudad = Console.ReadLine();
int edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola, {nombre}!. Tienes {edad} años, y vives en {ciudad}");

/* Formas de ejecutar el codigo:
 *  Desde el IDE: 
 *              * Click en el boton verde, en forma de Play. Al lado del debugger. (Visual Studio)
 *              * Click en la opcion Run, luego en Run Without Debugging. (Visual Studio Code)
 *  Desde terminal: Se necesita redirigirse hacia la carpeta donde se encuentra el Program.cs o main, y ejecutar el siguiente comando: dotnet run (Visual Studio & Visual Studio Code)
 * */
