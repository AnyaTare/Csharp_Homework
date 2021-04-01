using System;

namespace Task01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using switch 

            string operation;
            int result;

            Console.WriteLine("RealCalculator!");

            //First user input
            Console.Write("Enter first number:");
            string firstNum = Console.ReadLine();
            int num1 = int.Parse(firstNum);

            //Second user input
            Console.Write("Enter second number:");
            string secondNum = Console.ReadLine();
            int num2 = int.Parse(secondNum);

            Console.Write("Please enter desired operation (+, - , *, /) to be executed.");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + result);
                    break;

                case "+":
                    result = num1 + num2;
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + result);
                    break;
                default:
                    Console.WriteLine("There is no such operation. Please try again.");
                    break;
                   
            }
        }
    }
}
