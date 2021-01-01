using System;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
            car.Drive(5000.5);
            Console.WriteLine(car.Odometer);


            
        }
        

    }
}
