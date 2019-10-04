using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Acc
    {
        private string _name;
        private double _balance;


        public Acc(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                double tempBalance = _balance * -1;
                return $"{ _name}, { tempBalance.ToString("C2")}";
            }
            return $"{_name}, {_balance.ToString("C2")}";
        }
    }
}
