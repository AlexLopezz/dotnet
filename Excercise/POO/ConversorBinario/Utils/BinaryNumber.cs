using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario.Utils
{
    public class BinaryNumber
    {
        public string  Number { get; set; }
        
        private BinaryNumber(string number)
        {
            Number = number;
        }

        #region CASTEO IMPLICITO Y EXPLICITO
        public static implicit operator BinaryNumber(string number) => new BinaryNumber(number);
        public static explicit operator string(BinaryNumber number) => number.Number;
        #endregion

        public static string operator +(BinaryNumber binaryNumber, DecimalNumber decimalNumber)
        {
            var result = Conversor.ConvertDecimalToBinary(decimalNumber.Number);
            return 
        }
    }
}
