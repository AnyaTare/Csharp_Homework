using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01
{
    public class Car
    {
        public Car() { }
        public string Model { set; get; }
        public Driver Driver { set; get; }
        public short Speed { set; get; }

        public int CalculateSpeed()
        {
            return this.Driver.Skill *  this.Speed;
        }

        static public void RaceCars(Car firstCar, Car secondCar)
        {
            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed()) 
                Console.WriteLine($"Driver {firstCar.Driver.Name} wins by driving the {firstCar.Model} car.");
            else if (firstCar.CalculateSpeed() < secondCar.CalculateSpeed())
                Console.WriteLine($"Driver {secondCar.Driver.Name} wins by driving the {secondCar.Model} car.");
            else
                Console.WriteLine($"Nobody wins. Both of the drivers have equal skill of {firstCar.CalculateSpeed()}");
        }



    }
}
