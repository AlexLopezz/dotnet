using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Tickets
{
    public class Euro 
    {
        private double _amount;
        private static double _exchangeRateDollar;

    static Euro() { _exchangeRateDollar = 1.17; }

        public Euro(double amount) { _amount = amount; }

        public Euro(double amount, double exchangeRateDollar) : this(amount)
        {
            _exchangeRateDollar = exchangeRateDollar;
        }

        public double GetAmount() => _amount;
        public static double GetExchangeRateDollar() =>  _exchangeRateDollar;

        #region CASTEO EXPLICITO E IMPLICITO DE TIPOS
        public static implicit operator Euro(double n) => new Euro(n);
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetAmount() / _exchangeRateDollar);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        #endregion
        #region SUMA Y RESTA DE TIPOS
        public static Euro operator +(Euro e, Euro e2) => new Euro(e.GetAmount() + e2.GetAmount());
        public static Euro operator +(Euro e, Dolar d) => new Euro(e.GetAmount() + ((Euro)d).GetAmount());
        public static Euro operator +(Euro e, Peso p) => new Euro(e.GetAmount() + ((Euro)p).GetAmount());

        public static Euro operator -(Euro e, Euro e2) => new Euro(e.GetAmount() - e2.GetAmount());
        public static Euro operator -(Euro e, Dolar d) => new Euro(e.GetAmount() - ((Euro)d).GetAmount());
        public static Euro operator -(Euro e, Peso p) => new Euro(e.GetAmount() - ((Euro)p).GetAmount());
        #endregion
        #region IGUALDAD Y DIFERENTE DE...

        public static bool operator ==(Euro e, Euro e2) => e.GetAmount() == e2.GetAmount();
        public static bool operator ==(Euro e, Dolar d) => e == (Euro)d;
        public static bool operator ==(Euro e, Peso p) => e == (Euro)p;

        public static bool operator !=(Euro e, Euro e2) => !(e == e2);
        public static bool operator !=(Euro e, Dolar d) =>  !(e == d);
        public static bool operator !=(Euro e, Peso p) => !(e == p);
        #endregion
    }
}
