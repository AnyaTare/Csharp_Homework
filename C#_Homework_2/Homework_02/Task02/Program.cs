using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers!");

            Console.WriteLine("Enter first number:");
            string firstNum = Console.ReadLine();
            int num1 = int.Parse(firstNum);

            Console.WriteLine("Enter second number:");
            string secondNum = Console.ReadLine();
            int num2 = int.Parse(secondNum);

            Console.WriteLine("Enter third number:");
            string thirdNum = Console.ReadLine();
            int num3 = int.Parse(thirdNum);

            Console.WriteLine("Enter fourth number:");
            string fourthNum = Console.ReadLine();
            int num4 = int.Parse(fourthNum);

            Console.WriteLine((num1 + num2 + num3 + num4) / 4);


            Console.Read();
        }
    }
}
