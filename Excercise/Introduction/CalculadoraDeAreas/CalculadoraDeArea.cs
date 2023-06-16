using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAreas
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) => longitudLado * longitudLado;
        public static double CalcularAreaTriangulo(double baseT, double alturaT) => (baseT * alturaT) / 2;
        public static double CalcularAreaCirculo(double radio) => Math.PI * (radio * radio);

    }
}
