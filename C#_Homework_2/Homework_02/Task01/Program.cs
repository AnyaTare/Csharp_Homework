using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string operation;
            int result;

            Console.WriteLine("RealCalculator!");
            
            //First user input
            Console.Write("Enter first number:");
            string fstNum = Console.ReadLine();
            int num1 = int.Parse(fstNum);

            //Second user input
            Console.Write("Enter second number:");
            string secNum = Console.ReadLine();
            int num2 = int.Parse(secNum);

            //Operations selection
            Console.Write("Please enter desired operation (+, - , *, /) to be executed.");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                result = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                result = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + result);
                Console.ReadLine();
            }
            //One solution to catch error

            //else if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            //{
            //    Console.WriteLine("Wrong operation. Try again!");
            //}

            //Second solution to catch error
            else
            {
                Console.WriteLine("Ooops! You entered invalid operation input. Please try again.");
                Console.ReadLine();
            }
        }
    }
}
