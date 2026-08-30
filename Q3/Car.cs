using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleManagement
{
    public class Car : Vehicle
    {
        public int NumberOfDoors {  get; set; }
        public Car(string brand, string model) :base(brand, model) //passed constructor 
        { 
          
        }
        public override void Start()//overrides the inherited start
        {
                base.Start();//calls start in parent class 
                OpenTrunk();
        }

        private void OpenTrunk()
        {
            Console.WriteLine("Open trunk");
        }
    }
}
