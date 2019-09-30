using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance;
            float hour, min, sec;

            float timeInSeconds;
            float metersPerSeconds;
            float kilometersPerHours, milesPerHours;

            Console.Write("Input distance in meters: ");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input hour: ");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            sec = Convert.ToInt32(Console.ReadLine());

            timeInSeconds = (hour * 3600) + (min * 60) + sec;
            metersPerSeconds = distance / timeInSeconds;
            kilometersPerHours = (distance / 1000.0f) / (timeInSeconds / 3600.0f);
            milesPerHours = kilometersPerHours / 1.609f;

            Console.WriteLine($"Your speed in meters/sec is {metersPerSeconds}");
            Console.WriteLine($"Your speed in km/h is {kilometersPerHours}");
            Console.WriteLine($"Your speed in miles/h is {milesPerHours}");
            Console.Read();
            
        }
    }
}
