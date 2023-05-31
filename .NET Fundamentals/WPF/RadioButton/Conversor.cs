using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButton
{
    public static class Conversor
    {
        public static double CmToInches(double v1) => v1 * 0.39370;
        public static double InchesToCm(double v1) => v1 / 0.39370;
    }
}
