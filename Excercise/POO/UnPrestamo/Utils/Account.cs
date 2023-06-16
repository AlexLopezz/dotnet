using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnPrestamo.Utils
{
    public class Account
    {
        public string Owner { get; set; }
        public decimal AmountMoney { get; set; }

        public Account(string owner, decimal count)
        {
            Owner = owner;
            AmountMoney = count;
        }

        public void ShowAccount()
        {
            Console.WriteLine("Cuenta a cargo de: {0}\nSaldo actual en la cuenta: {1:C2}", Owner, AmountMoney);
        }
        public void Deposit(decimal money)
        {
            if(money > 0)
            {
                AmountMoney += money;
            }
        }
        public void Withdraw(decimal money)
        {
            AmountMoney -= money;
        }
    }
}
