using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private decimal _interest;
        private decimal _balance;
        private decimal _annualInterestRate;

        public SavingsAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public decimal Interest
        {
            get { return _interest; }
        }
        public decimal SetAnnualInterest
        {
            set { _annualInterestRate = value; }
        }

        public decimal Withdrawal(decimal amount)
        {
            return _balance -= amount;
        }

        public decimal Deposit(decimal amount)
        {
            return _balance += amount;
        }
        public void MonthlyInterest()
        {
            decimal monthlyRate = _annualInterestRate / 12;
            _interest += monthlyRate * _balance;
            _balance += _interest * monthlyRate;
        }
    }
}
