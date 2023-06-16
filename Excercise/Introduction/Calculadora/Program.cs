/*
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

    *Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
    *Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
        *El método devolverá el resultado de la operación.
    *Validar (privado): Recibirá como parámetro el segundo operando. 
        *Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        *Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/

using Calculadora;

//Variables a utilizar
double number = 0, //Primer operando
       number2 = 0; //Segundo operando
char aritmeticOperator = '+'; //Caracter del operando.
bool follow = true, //Flag para seguir el bucle(o no).
     validOperator = false; //Flag para validar el operando que ingresa el usuario.

while (follow)
{
    //Almacenamos los datos y valores:
    Console.Write("Ingrese un numero: ");
    number = double.Parse(Console.ReadLine());
    Console.Write("Ingrese otro numero: ");
    number2 = double.Parse(Console.ReadLine());

    //Esto se iterara hasta que el usuario ingrese la tecla 'S'
    while (!validOperator)
    {
        Console.WriteLine("----------------------");
        Console.Write("¿Que desea realizar?\n(+) Suma\n(-) Resta\n(*) Multiplicacion\n(/) Division\nDecision: ");
        aritmeticOperator = Console.ReadKey().KeyChar; //Almacenamos el operando

        if (aritmeticOperator == '+' || aritmeticOperator == '-' ||
            aritmeticOperator == '*' || aritmeticOperator == '/')
        {
            validOperator = true; //Si cumple con algunos de los operandos disponibles, salimos de la verificacion.
        }
        else
        {
            Console.WriteLine("\nOperador incorrecto, intentelo de nuevo...");
        }
    }
    //ALmacenamos el resultado final del calculo, si todo salio bien
    double result = Calculator.Calculate(number, number2, aritmeticOperator);
    Console.WriteLine($"\nRESULTADO: {result}"); //Informamos

    Console.WriteLine("¿Desea continuar? (S/N)");

    if (!(Console.ReadKey(true).KeyChar == 'S')) follow = false;
    else Console.Clear(); //Si desea continuar limpiamos la consola... y vuelve a ejecutarse el programa.

}