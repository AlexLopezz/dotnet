using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Tickets
{
    public class Dolar
    {
        private double _amount;
        private static double _exchangeRateDollar;

        public Dolar(double amount) { _amount = amount; }

        static Dolar() { _exchangeRateDollar = 1; }

        public double GetAmount() => _amount;
        public static double GetExchangeRateDollar() => _exchangeRateDollar;

        #region CASTEO EXPLICITO E IMPLICITO
        public static implicit operator Dolar(double n) => new Dolar(n);
        public static explicit operator Euro(Dolar d)
        {
            double convertDolarToEuro = d.GetAmount() * Euro.GetExchangeRateDollar();
            return new Euro(convertDolarToEuro);
        }
        public static explicit operator Peso(Dolar d)
        {
            double convertDolarToPeso = d.GetAmount() * Peso.GetExchangeRateDollar();
            return new Peso(convertDolarToPeso);
        }
        #endregion
        #region SUMA Y RESTA DE TIPOS
        public static Dolar operator +(Dolar d, Dolar d2) => new Dolar(d.GetAmount() + d2.GetAmount());
        public static Dolar operator +(Dolar d, Euro e) =>  new Dolar(d.GetAmount() + ((Dolar)e).GetAmount());
        public static Dolar operator +(Dolar d, Peso p) => new Dolar(d.GetAmount() + ((Dolar)p).GetAmount());

        public static Dolar operator -(Dolar d, Dolar d2) => new Dolar(d.GetAmount() - d2.GetAmount());
        public static Dolar operator -(Dolar d, Euro e) => new Dolar(d.GetAmount() - ((Dolar)e).GetAmount());
        public static Dolar operator -(Dolar d, Peso p) => new Dolar(d.GetAmount() - ((Dolar)p).GetAmount());
        #endregion
        #region IGUALDAD Y DESIGULADAD
        public static bool operator ==(Dolar d, Dolar d2) => d.GetAmount() == d2.GetAmount();
        public static bool operator ==(Dolar d, Euro e) => d == (Dolar)e;
        public static bool operator ==(Dolar d, Peso p) => d == (Dolar)p;
        public static bool operator !=(Dolar d, Dolar d2) => !(d == d2);
        public static bool operator !=(Dolar d, Euro e) => !(d == e);
        public static bool operator !=(Dolar d, Peso p) => !(d == p);
        #endregion
    }
}
