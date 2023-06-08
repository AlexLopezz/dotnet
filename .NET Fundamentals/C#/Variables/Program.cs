// Tipo de datos: https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/types / https://www.w3schools.com/cs/cs_data_types.php

//Existen 6 tipos de datos generales:

// Numero reales: 
using Variables;

int entero = 12;

// De numeros flotantes: Ambos representan lo mismo, con la diferencia que el tipo double, tiene aun mas precision que float.
float flotante = 12.5f;
double doubl = 25.5;

// De tipo caracteres: string representa una cadena de caracteres, mientras que char solo a un caracter.
string cadena = "Esto es una cadena";
char c = 'A';

// Valores booleanos: true / false.
bool booleano = false && true;

//Esto, no es lo mismo.
int? a = null; // No inicializamos la variable. Es decir, no tiene valor. Su valor es null.
string b = ""; //Inicializamos la variable. Tiene como valor "". Es decir vacio.

Console.WriteLine(a + 1); //No imprimira nada, debido a que 'a' es null.
Console.WriteLine(a.HasValue); //Verificamos si tiene un valor la variable.
Console.WriteLine(b); //Nos imprimira vacio.

//Conversion de tipos: Explicita e Implicita


long e = entero; // Casteo implicito. Va de menor a meyor. Se castea el tipo entero a long de forma automatica.
flotante = (float)doubl; //Casteo explicito. Va de mayor a menor. Se castea indicando entre parentesis el tipo de dato a castear. De forma manual.

/* Operadores: Hay 4 tipos.
 * Aritmeticos (+, -, *, /, %, ++, --)
 * De asignacion (= , +=, -=, *=, /=)
 * De comparacion (<, <=, >, >=, ==, !=)
 * Logicos (&&, ||, !)
 */

// Op. Adicion, se utilza para realizar adiciones aritmeticas u concatenacion: 

int suma = 12 + 54;
Console.WriteLine(suma);

Console.WriteLine("La suma total es "+suma+10); //Concatenacion.

//Auto  / Post - Incremento / Decremento
int edad = 21;
Console.WriteLine("Mi edad es "+ edad++); // AutoIncremento. se realiza indicando el '++' a la variable. Lo que hara es mostrar por consola el valor de la variable y luego incrementarla a uno.
Console.WriteLine(edad); //Veremos que la edad aumento un 'año' mas.

Console.WriteLine("Mi edad es "+ ++edad); //PostIncremento. Es lo inverso, en este caso incrementara a uno la variable, y luego mostrara por consola.
Console.WriteLine(edad); //Veremos que la edad coincide con lo que se muestra por pantalla.

//La misma logica trata con el decremento:
Console.WriteLine(edad--); //Aqui mostrara por pantalla la edad y luego decrementara su valor.
Console.WriteLine(--edad); //Aqui decrementara el valor de la edad y luego mostrara.

Console.WriteLine(edad / 2); //Aqui estamos indicando la mitad de la edad.
Console.WriteLine($"La edad({edad}) es un numero par? "+ (edad % 2 == 0)); // Aqui estamos preguntando si la edad es un numero par. con el operador modulo.

//Op. Asigancion
string nombre = "Alex"; // Es el mas basico de todo, su uso implica la asignacion de un valor a una variable(ejemplo)
//Op. Asignar a lo que ya esta establecido: 

// nombre -= "dor." No se puede realizar esta asignacion, debido a que C# no tiene esa capacidad de razonamiento.


//Estamos asignando mas valor, a lo que ya estaba asignado. (+=).
nombre += " Es un programdor."; 
edad += 10;

edad -= 10; // Estamos asignando menos valor, a lo que ya esta asignado.
edad *= 10; // Estamos multiplicando el valor ya asignado por 10.
edad /= 2; // Estamos obteniendo la mitad de la edad.

bool esMayor = edad > 18; //Op. comparacion mayor a
esMayor = edad < 18; //Op. comparaion menor a

edad = 18;
esMayor = edad <= 18; //Op. comperacion menor/igual a
esMayor = edad >= 18; //Op. comparacion mayor/igual a
esMayor = edad++ == 18; //Op. comparacion igual a
esMayor = edad != 18; //Op. comparacion diferente de

esMayor = !esMayor; //Op. logico NOT
esMayor = esMayor && edad != 18; //Op. AND ambos valores logicos deben ser verdaderos para dar true.
esMayor = esMayor || edad >= 18; //Op. OR algunos de los valores logicos debe ser verdadero para dar true.

Excercise.Excercise1();
Excercise.Excercise2();
Excercise.Excercise3();


