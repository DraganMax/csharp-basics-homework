using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        public string _name;
        public double _price;
        public int _amount;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }
        
        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, {_price} EUR, {_amount} units");
        }

        public void ChangeQuantity(int units)
        {
            _amount += units;
        }

        public void ChangePrice(double newPrice)
        {
            _price = newPrice;
        }
    }
}
