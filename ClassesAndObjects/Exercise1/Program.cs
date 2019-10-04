using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product iPhone = new Product("iPhone 5s", (double)999.99, 3);
            Product mouse = new Product("Logitech mouse", (double)70.00, 14);
            Product printer = new Product("Epson EB-U05", (double)440.46, 1);
            mouse.PrintProduct();
            printer.PrintProduct();
            iPhone.PrintProduct();
            mouse.ChangeQuantity(5);
            mouse.ChangePrice(double.Parse(Console.ReadLine()));
            mouse.PrintProduct();
            Console.ReadLine();
        }
    }
}
