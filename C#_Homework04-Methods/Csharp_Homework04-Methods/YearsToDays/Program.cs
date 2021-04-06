using System;

namespace YearsToDays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert an age number you wish to convert to days: ");
                int age = 0;
                bool isAgeValidInteger = int.TryParse(Console.ReadLine(), out age);

                if (age >= 0)
                {
                    AgeToDays(age);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again!");
                };

            }

        }

        public static int AgeToDays(int age)
        {
            int days = 365;
            int ageInDays = days * age;
            Console.WriteLine($"The entered age: {age} converted in days is: {ageInDays} days.");
            return ageInDays;

        }
    }
}
