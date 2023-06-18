using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Tickets
{
    public class Peso
    {
        private double _amount;
        private static double _exchangeRateDollar;

        static Peso() { _exchangeRateDollar = 102.65; }

        public Peso(double amount) { _amount = amount; }

        public Peso(double amount, double exchangeRateDollar) : this(amount)
        {
            _amount = amount;
            _exchangeRateDollar = exchangeRateDollar;
        }

        public double GetAmount() => _amount;
        public static double GetExchangeRateDollar() => _exchangeRateDollar;

        #region CASTEO EXPLICITO E IMPLICITO DE TIPOS
        public static implicit operator Peso(double n) => new Peso(n);
        public static explicit operator Dolar(Peso p) =>  new Dolar(p.GetAmount() / _exchangeRateDollar);
        public static explicit operator Euro(Peso p) => (Euro)((Dolar)p);
        #endregion
        #region SUMA Y RESTA DE TIPOS
        public static Peso operator +(Peso p, Peso p2) => new Peso(p.GetAmount() + p2.GetAmount());
        public static Peso operator +(Peso p, Dolar d) => new Peso(p.GetAmount() + ((Peso)d).GetAmount());
        public static Peso operator +(Peso p, Euro e) => new Peso(p.GetAmount() + ((Peso)e).GetAmount());
        public static Peso operator -(Peso p, Peso p2) => new Peso(p.GetAmount() - p2.GetAmount());
        public static Peso operator -(Peso p, Dolar d) => new Peso(p.GetAmount() - ((Peso)d).GetAmount());
        public static Peso operator -(Peso p, Euro e) => new Peso(p.GetAmount() - ((Peso) e).GetAmount());
        #endregion
        #region IGUAL Y DIFERENTE DE...
        public static bool operator ==(Peso p, Peso p2) => p.GetAmount() == p2.GetAmount();
        public static bool operator ==(Peso p, Dolar d) => p == (Peso)d;
        public static bool operator ==(Peso p, Euro e) => p == (Peso)e;
        public static bool operator !=(Peso p, Peso p2) => !(p == p2);
        public static bool operator !=(Peso p, Dolar d) => !(p == d);
        public static bool operator !=(Peso p, Euro e) => !(p == e);
        #endregion
    }
}
