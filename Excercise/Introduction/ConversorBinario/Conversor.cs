using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    public static class Conversor
    {
        public static string ConvertDecimalToBinary(int number)
        {
            int rest = number; //Almacenamos el resto de la division, en primera instancia almacenara el numero en si.
            StringBuilder sb = new StringBuilder(); //Como es una iteracion, debemos trabajar con strings mutables.(modificables)

            do
            {
                if (rest % 2 == 0) //Si es par, almacenamos como 0.
                {
                    sb.Append("0");
                }
                else
                {
                    sb.Append("1"); //Si no como 1(impar)
                }
                rest /= 2; //Luego de verificar, actualizamos el resto de la division, hasta llegar a 0(en enteros)

            } while (rest > 0);

            return sb.ToString(); //Retornamos el string armado.
        }
        public static int ConvertBinaryToDecimal(int number)
        {
            int numberFinal = 0, //Se almacenara el valor final del numero convertido.
                pow = 0; //Se utilizara como potencia.
            
            string numberStr = number.ToString(); //Convertimos a string el numero pasado por parametro.
            pow = (numberStr.Length - 1); //Indicamos la potencia al ultimo numero - 1 del tamaño del string

            for (var i = 0; i < numberStr.Length; i++)
            {
                if (numberStr[i] == '1')
                {
                    numberFinal += (int)Math.Pow(2, pow); //Sumamos todas las potencias, las cuales sean 1.
                }
                pow--; //Decrementamos la potencia para los siguientes valores.
            }

            return numberFinal; //Retornamos el numero final
        }
    }
}



