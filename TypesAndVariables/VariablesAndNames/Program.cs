using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            //int cars, drivers, passengers, cars_not_driven, cars_driven;
            //double seatsInACar, carpool_capacity, average_passengers_per_car;

            /*cars = 100; //cars
            seats_in_a_car = 4.0; //seats in a car
            drivers = 30; // drivers
            passengers = 90; // passengers
            cars_not_driven = cars - drivers; // free cars
            cars_driven = drivers; // cars driven at the moment
            carpool_capacity = cars_driven * seats_in_a_car; // carpool capacity
            average_passengers_per_car = passengers / cars_driven; // average passengers per car*/

            int cars = 100; 
            double seatsInACar = 4.0; 
            int drivers = 30; 
            int passengers = 90; 
            int carsNotDriven = cars - drivers; // free cars
            int carsDriven = drivers; // cars driven at the moment
            double carpoolCapacity = carsDriven * seatsInACar; // carpool capacity
            double averagePassengersPerCar = passengers / carsDriven; // average passengers per car

            Console.WriteLine($"There are {cars} cars available.");
            Console.WriteLine($"There are only {drivers} drivers available.");
            Console.WriteLine($"There will be {carsNotDriven} empty cars today.");
            Console.WriteLine($"We can transport {carpoolCapacity} people today.");
            Console.WriteLine($"We have {passengers} to carpool today.");
            Console.WriteLine($"We need to put about  {averagePassengersPerCar} in each car.");
            Console.ReadKey();
        }
    }
}