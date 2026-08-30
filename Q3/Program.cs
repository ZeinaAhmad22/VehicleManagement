using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("Toyota", "Corolla");
            Vehicle motorcycle = new Motorcycle("Harley Davidson", "Iron 883");
            car.Start();
            Console.WriteLine(car.ToString());

            Console.WriteLine();

            motorcycle.Start();
            Console.WriteLine(motorcycle.ToString());
        }
    }

}
