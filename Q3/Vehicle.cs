using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public class Vehicle
    {
        public string Brand {  get; set; }
        public string Model {  get; set; }
        public Vehicle(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public virtual void Start()
        {
            Console.WriteLine($"{Brand} {Model} is starting");
        }
        public override string ToString()
        {
            return $"Brand: {Brand}" +
                   $"\nModel: {Model}";
        }

    }
}
