/*
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
  *El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario. 
  *El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
*/

int number = ConversorBinario.Conversor.ConvertBinaryToDecimal(1010011);
string binaryNumber = ConversorBinario.Conversor.ConvertDecimalToBinary(36);

Console.WriteLine($"Binario: 1010011 a numero: {number}");
Console.WriteLine($"Numero: 36 a binario: {binaryNumber}");