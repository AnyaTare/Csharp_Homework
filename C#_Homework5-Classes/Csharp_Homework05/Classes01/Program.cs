using System;

namespace Classes01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];
            Driver[] drivers = new Driver[4];

            Car hyundai = new Car()
            {
                Model = "Hyundai",
                Speed = 250,
            };

            Car mazda = new Car()
            {
                Model = "Mazda",
                Speed = 210,
            };

            Car ferrari = new Car()
            {
                Model = "Ferari",
                Speed = 300,
            };


            Car porsche = new Car()
            {
                Model = "Porsche",
                Speed = 290,
            };


            Driver firstDriver = new Driver()
            {
                Name = "Bob",
                Skill = 300,
            };
            Driver secondDriver = new Driver()
            {
                Name = "Greg",
                Skill = 250,
            };
            Driver thirdDriver = new Driver()
            {
                Name = "Jill",
                Skill = 150,
            };
            Driver fourthDriver = new Driver()
            {
                Name = "Anne",
                Skill = 210,
            };

            cars[0] = hyundai;
            cars[1] = mazda;
            cars[2] = ferrari;
            cars[3] = porsche;

            drivers[0] = firstDriver;
            drivers[1] = secondDriver;
            drivers[2] = thirdDriver;
            drivers[3] = fourthDriver;

            Console.WriteLine("Please select a drivers name from the driver list bellow: ");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            Console.Write("Please insert the drivers number: ");
            int driversNumber = 0;
            bool isValidDriverNumber = int.TryParse(Console.ReadLine(), out driversNumber);

            Console.WriteLine("****************************************");


            Console.WriteLine("Please select a car model from the car list bellow: ");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            Console.Write("Please insert the cars number: ");
            int numOfCar = 0;
            bool isValidCarNumber = int.TryParse(Console.ReadLine(), out numOfCar);
        }
    }
}
