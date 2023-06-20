using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utils
{
    public static class Calculator
    {
        static double Sum(double number, double number2) => number + number2;
        static double Substract(double number, double number2) => number - number2;
        static double Multiplication(double number, double number2) => number * number2;
        static double Division(double number, double number2) => number / number2;
    }
}
