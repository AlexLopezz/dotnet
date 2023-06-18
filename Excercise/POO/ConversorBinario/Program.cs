/*
Partiendo del ejercicio Conversor binario, se pide agregar las clases:
NumeroBinario:
    * Único atributo numero de tipo string.
    * Único constructor privado (recibe un parámetro de tipo string).

NumeroDecimal:
    * Único atributo numero de tipo double.
    * Único constructor privado (recibe un parámetro de tipo double).

Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:

NumeroBinario:
string + (NumeroBinario, NumeroDecimal)
string - (NumeroBinario, NumeroDecimal)
bool == (NumeroBinario, NumeroDecimal)
bool != (NumeroBinario, NumeroDecimal)

NumeroDecimal:
double + (NumeroDecimal, NumeroBinario)
double - (NumeroDecimal, NumeroBinario)
bool == (NumeroDecimal, NumeroBinario)
bool != (NumeroDecimal, NumeroBinario)

Agregar conversiones implícitas para poder ejecutar:
NumeroBinario objBinario = "1001";
NumeroDecimal objDecimal = 9;

Agregar conversiones explícitas para poder ejecutar:
string binario = (string)objBinario;
double numeroDecimal = (double)objDecimal;
*/