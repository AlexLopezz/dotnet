using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calculator
    {
        public static double Calculate(double number, double number2, char aritmeticOperator)
        {
            double result = 0;
            switch (aritmeticOperator)
            {
                case '+':
                    result = number + number2;
                    break;
                case '-':
                    result = number - number2;
                    break;
                case '*':
                    result = number * number2;
                    break;
                case '/':
                    if (Valid(number2))
                    {
                        result = number / number2;
                    }
                    break;
            }

            return result;
        }
        private static bool Valid(double number2) => number2 != 0;

    }
}
