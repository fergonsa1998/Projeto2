using ClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASSES QUE NÃO PODEM SER INSTANCIADAS

            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0;
            foreach (Account acc in list) 
            { 
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance:" + sum.ToString("F2", CultureInfo.CurrentCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account Acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + Acc.Number
                    + ": "
                    + Acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
