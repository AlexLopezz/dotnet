/* Se debe pedir el ingreso por teclado de N cantidad de empleados de una fábrica, con los siguientes datos: 
 * valor hora
 * Nombre
 * Antigüedad (en años)
 * Cantidad de horas trabajadas en el mes.

Se pide calcular el importe a cobrar teniendo en cuenta que:
 * El total resulta de:  multiplicar el valor hora por la cantidad de horas trabajadas.
 *                       hay que sumarle la cantidad de años trabajados multiplicados por $150
 *                       y al total de todas esas operaciones restarle el 13% en concepto de descuentos.


 Mostrar el recibo correspondiente con:
 * Nombre
 * Antigüedad
 * Valor hora
 * total a cobrar en bruto
 * total a cobrar neto de todos los empleados ingresados.
 
 */

//Vamos a abstraer en bloques nuestro codigo en tres funciones y un metodo main.

//Este metodo permite calcular al importe neto del sueldo a cobrar.
double amountNetReceivable(double valueHour, double countWorkHour, int antiquity) 
{
    //El valor neto, tomaremos en cuenta el impuesto del 13% a descontar al sueldo bruto
    double taxes = 0;

    double amount = (valueHour * countWorkHour) + (antiquity * 150); //Calculamos el sueldo bruto
    taxes = amount * 0.13;
    
    amount -= taxes; //Descontamos al sueldo los impuesto.

    return amount;
}
//Este metodo permite calcular al importe bruto del sueldo a cobrar.
double amountGrossReceivable(double valueHour, double countWorkHour, int antiquity)
{
    return (valueHour * countWorkHour) + (antiquity * 150); //Calculamos y retornamos el sueldo bruto.
}

//Este metodo mostrara el resultado esperado del programa con el nombre, antiguedad, valor por hora y importe neto y bruto.
void ShowAmount(string name, int quantity, int countWorkHour, double valueHour)
{
    Console.WriteLine($"Nombre: {name}");
    Console.WriteLine($"Antiguedad: {quantity}");
    Console.WriteLine($"Valor por hora trabajada: ${valueHour}");
    Console.WriteLine($"Importe total a cobrar en bruto: ${amountGrossReceivable(valueHour, countWorkHour, quantity)}");
    Console.WriteLine($"Importe total a cobrar en neto: ${amountNetReceivable(valueHour, countWorkHour, quantity)}");
}

//Aqui pediremos al usuario que ingrese la N cantidad de usuarios.
int countEmployee = 0;
Console.Write("Cuantos empleados desea verificar el importe a combrar?\nRespesta: ");
countEmployee = int.Parse(Console.ReadLine());

//Iteraremos la N veces para registrar los datos de esos empleados y luego mostrar el importe:
for (var i = 0; i < countEmployee; i++)
{
    //Declaramos todas las variables que vamos a estar utilizando para recopilar los datos de los empleados: 
    int quantity = 0,
        countWorkHour = 0;
    double valueHour = 0;
    string name = "";

    Console.WriteLine($"*Empleado N° {(i+1)}");
    Console.Write("> Nombre: ");
    name = Console.ReadLine();
    Console.Write("> Antiguedad: ");
    quantity = int.Parse(Console.ReadLine());
    Console.Write("> Valor hora: $");
    valueHour = int.Parse(Console.ReadLine());
    Console.Write("> Cantidad de horas trabajadas en el mes: ");
    countWorkHour = int.Parse(Console.ReadLine());

    //Una vez determinado los datos, procedemos a mostrar lo pedido en el enunciado: 
    Console.WriteLine("------------------------------");
    ShowAmount(name, quantity, countWorkHour, valueHour);
    Console.WriteLine("------------------------------");
}