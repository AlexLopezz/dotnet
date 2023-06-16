/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:
titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.

En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo
*/

using UnPrestamo.Utils;

Account myAcc = new Account("Alex Lopez", 2500L);

//Depositamos dinero en la cuenta
myAcc.Deposit(1000L);
myAcc.ShowAccount();
//Retiramos dinero de la cuenta
myAcc.Withdraw(2000L);
myAcc.ShowAccount();
//Volvemos a retirar dinero, para esta vez verificar si el saldo es menor a 0.
myAcc.Withdraw(4000L);
myAcc.ShowAccount();

