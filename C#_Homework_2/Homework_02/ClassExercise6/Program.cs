using System;

namespace ClassExercise6
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


            //Code that can test which is larger

            if (num1 > num2)
            {
                Console.WriteLine("First number is larger.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Second number is larger.");
            }
            else
            {
                Console.WriteLine("This numbers are equal.");
            }

            //Code that can test if even or odd

            if (num1 > num2 && num1 % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else if (num1 > num2 && num2 % 2 == 0)
            {
                Console.WriteLine("This number is odd.");
            }
            else if (num2 > num1 && num1 % 2 == 0)
            {
                Console.WriteLine("This number is odd.");
            }
            else if (num2 > num1 && num2 % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("Please try again...");
            }
            Console.ReadLine();
        }
    }
}
