using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Acc benben = new Acc("Benson", 17.5);
            Acc genry = new Acc("Genry", -15.3);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.WriteLine(genry.ShowUserNameAndBalance());
            Console.ReadLine();
        }
    }
}
