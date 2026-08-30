using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar {  get; set; }
        public Motorcycle(string brand, string model) : base(brand, model) //passed constructor
        {
           
        }
        public override void Start()
        {
            base.Start();//calls start from parent class
            Kickstand();
        }
        private void Kickstand()
        {
            Console.WriteLine("Pull back kickstand");
        }
       
    }
}
