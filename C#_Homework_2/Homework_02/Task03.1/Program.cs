using System;

namespace Task03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Second solution attempt: Swapping with * and /

            //User input one

            Console.WriteLine("Enter first number:");
            string firstNum = Console.ReadLine();
            int num1 = int.Parse(firstNum);

            //User input two

            Console.WriteLine("Enter second number:");
            string secondNum = Console.ReadLine();
            int num2 = int.Parse(secondNum);

            Console.WriteLine("Before swapping first number is = " + num1 + " , second number is = " + num2);

            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;

            //Outcome 

            Console.Write("After swapping first number is = " + num1 + " , second number is = " + num2);

            Console.Read();
        }
    }
}
