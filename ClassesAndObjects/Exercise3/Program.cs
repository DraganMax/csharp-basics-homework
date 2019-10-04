using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New odometer");
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);

            int filledLiters = 7;
            int killometersTravelled = 101;

            for (int i = 0; i < filledLiters; i++)
            {
                fuelGauge.IncreaseOfFuel();
            }

            Console.WriteLine($"Fuel level: {fuelGauge.ReportLevel()}");
            Console.WriteLine("running");

            for (int i = 0; i < killometersTravelled; i++)
            {
                odometer.MaxMileage();
                odometer.ReportMileage();
                Console.WriteLine($"Odometer report: {odometer.ReportMileage()} km, Fuel level: {fuelGauge.ReportLevel()}");
           
            }

            
            Console.ReadLine();
        }
    }
}
