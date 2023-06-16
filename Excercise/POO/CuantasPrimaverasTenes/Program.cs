/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:
nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:
Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.
*/

using CuantasPrimaverasTenes.Utils;

Person person1 = new Person(
    "Jorge Oliveira",
    "35456765",
    new DateTime(2003, 04, 23));

Person person2 = new Person(
    "Daniela Fernandez",
    "7898764",
    new DateTime(2006, 02, 23));

Person person3 = new Person(
    "Alex Lopez",
    "43697935",
    new DateTime(2001, 09, 10));

person1.IsLegalAge();
person2.IsLegalAge();
person3.IsLegalAge();