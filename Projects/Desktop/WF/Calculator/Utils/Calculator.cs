using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utils
{
    public static class Calculator
    {
        public static double Sum(double number, double number2) => number + number2;
        public static double Substract(double number, double number2) => number - number2;
        public static double Multiplication(double number, double number2) => number * number2;
        public static double Division(double number, double number2) => number / number2;
    }
}
