using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal withdrawAmount = 0;
            decimal depositAmount = 0;
            
            Console.Write("How much money is in the account?: ");
            SavingsAccount balance = new SavingsAccount(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Enter the annual interest rate: ");
            balance.SetAnnualInterest = decimal.Parse(Console.ReadLine());

            Console.Write("How long has your account been opened?: ");
            int months = int.Parse(Console.ReadLine());
            if (months > 12)
            {
                throw new Exception("There is only 12 months in the year!");
            }

            for (int i = 1; i <= months; i++)
            {
                Console.Write($"Enter amount deposited into the account during the month {i}: ");
                decimal deposit = decimal.Parse(Console.ReadLine());
                depositAmount += deposit;
                balance.Deposit(deposit);

                Console.Write($"Enter amount withdrawn from the account during the month {i}: ");
                decimal withdraw = decimal.Parse(Console.ReadLine());
                withdrawAmount += withdraw;
                balance.Withdrawal(withdraw);

                balance.MonthlyInterest();
            }
            Console.WriteLine($"Total deposited: {depositAmount.ToString("C2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Total withdrawn: {withdrawAmount.ToString("C2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Interest earned: {balance.Interest.ToString("C2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Ending balance: {balance.Balance.ToString("C2", new CultureInfo("en-US"))}");

            Console.Read();
        }
    }
}
