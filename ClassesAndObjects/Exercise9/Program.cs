using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Points p1 = new Points(5, 2);
            Points p2 = new Points(-3, 6);
            SwapPoints(p1, p2);
            Console.WriteLine($"({p1.x}, {p1.y})");
            Console.WriteLine($"({p2.x}, {p2.y})");
            Console.Read();
        }

        public static void SwapPoints(Points first, Points second)
        {
            int tempOne = first.x;
            int tempSecond = first.y;

            first.x = second.x;
            first.y = second.y;

            second.x = tempOne;
            second.y = tempSecond;
        }
    }
}
