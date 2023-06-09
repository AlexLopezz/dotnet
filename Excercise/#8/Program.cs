/*
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
Para el ejemplo anterior, la altura ingresada fue de 5.
*/

//Este metodo servira para dibujar un triangulo con el tamaño que se pasa por parametro.
void DrawingTriangle(int size)
{
    if(size > 0)
    {
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("No es posible dibujar un triangulo con un tamaño igual/menor a 0.");
    }
}


int sizeTriangle = 0;
// Pedimos al usuario la altura del triangulo: 
Console.Write("Por favor, ingrese la altura que desea del triangulo: ");
sizeTriangle = int.Parse(Console.ReadLine());
Console.WriteLine("> Resultado del triangulo: ");
//Dibujamos el triangulo
DrawingTriangle(sizeTriangle);