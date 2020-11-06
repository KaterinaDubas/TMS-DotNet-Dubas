using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Atm acc = new Atm();
            acc.BalanceHandler += GetInfo;
            acc.PutMoney(300);
            acc.GetMoney(130);
            acc.Info();

            Console.ReadKey();
        }

        public static void GetInfo(decimal amount, string operation)
        {
            Console.WriteLine($"Operation: {operation}. Current balance: {amount}");
        }
    }
}