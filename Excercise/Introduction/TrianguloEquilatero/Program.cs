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


void DrawingTriangleEqui(int size)
{
    for(var row = 1; row <= size; row++)
    {
        //Este for servira para indicar los espacios en blanco 
        for(var col = 0; col < (size - row); col++)
        {
            Console.Write(" ");
        }

        //Este for servira para indicar los asteriscos
        for(var ast = 0; ast < (row * 2)-1; ast++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

int sizeTriangle = 0;
Console.Write("> Ingrese por favor la longitud de su triangulo equilatero: ");
sizeTriangle = int.Parse(Console.ReadLine());

Console.WriteLine("* Triangulo resultante: ");
DrawingTriangleEqui(sizeTriangle);