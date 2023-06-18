using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador.Utils
{
    public class Adder
    {
        public int CountAdd { get; set; }
        public Adder(int count) 
        {
            CountAdd = count;
        }
        public Adder() : this(0) { }
        /// <summary>
        /// Este metodo sumara los valores pasados por parametros y devolvera el resultado.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Devuelve un long, con la suma de los dos parametros pasados por parametro.</returns>
        public long Add(long number1, long number2)
        {
            CountAdd++;
            return number1 + number2;
        }

        /// <summary>
        /// Este metodo concatenara dos strings y luego lo devolvera
        /// </summary>
        /// <param name="word"></param>
        /// <param name="word2"></param>
        /// <returns>Devolvera una string concatenado</returns>
        public string Add(string word, string word2)
        {
            CountAdd++;
            return word + word2;
        }

        //Conversion explicita, cuando realizamos una conversion explicita a int(casteo), retornara la cantidad sumada en el objeto.
        public static explicit operator int(Adder d) => d.CountAdd; 

        //Sobrecarga del operador + (suma): Retornara la suma entre cantidadSuma de los dos tipos.
        public static long operator +(Adder a, Adder a2) => a.CountAdd + a2.CountAdd;
        //Sobrecarga del operador | (pipe): Retornara true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
        public static bool operator |(Adder a, Adder a2) => a.CountAdd == a2.CountAdd;
    }
}
