using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario.Utils
{
    public class DecimalNumber
    {
        public double Number { get; set; }

        private DecimalNumber(double number) { Number = number; }

        

        #region CASTEO IMPLICITO Y EXPLICITO
        public static implicit operator DecimalNumber(double number) => new DecimalNumber(number);
        public static explicit operator double(DecimalNumber decimalNumber) => decimalNumber.Number;
        #endregion

    }
}
