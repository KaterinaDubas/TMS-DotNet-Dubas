using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class Atm
    {
        public decimal _balance = 0M;
        public event Action<decimal, string> BalanceHandler;


        public void PutMoney(decimal sum)
        {
            _balance += sum;
            BalanceHandler?.Invoke(sum, "put");
        }

        public void GetMoney(decimal sum)
        {
            _balance -= sum;
            BalanceHandler?.Invoke(sum, "get");
        }
        public void Info ()
        {
            BalanceHandler?.Invoke(_balance, "show");
        }
    }
}