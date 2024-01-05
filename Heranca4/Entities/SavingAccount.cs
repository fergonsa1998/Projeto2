using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca4.Entities
{
    sealed class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() 
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestrate) 
            : base(number, holder, balance)
        {
            InterestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }


    }
}
