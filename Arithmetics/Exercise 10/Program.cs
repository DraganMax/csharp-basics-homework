using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            var x = i > 4 ? (i < 6 ? "Yes" : "No") : "All's okay";
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
