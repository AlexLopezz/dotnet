/*
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
    *El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
    *Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
Mostrar el resultado en la consola. 
*/

double baseT = 0,
    heightT = 0;

static double lengthHypotenuse(double baseT, double heightT)
{
    double resultPow = 0;
    resultPow = (Math.Pow(baseT, 2) + Math.Pow(heightT, 2));
    return Math.Sqrt(resultPow);
}

Console.Write("Ingrese la base del triangulo: ");
baseT = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura del triangulo: ");
heightT = double.Parse(Console.ReadLine());

Console.WriteLine("La longitud de la hipotenusa es: {0:N2}", lengthHypotenuse(baseT, heightT));

