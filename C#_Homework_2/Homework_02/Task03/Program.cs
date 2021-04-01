using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //First solution attempt : Swapping with + and -

            //First input from user
            
            Console.WriteLine("Enter the first number:");
            string number1 = Console.ReadLine();
            int firstNum = int.Parse(number1);

            //Second input from user
            
            Console.WriteLine("Enter the second number:");
            string number2 = Console.ReadLine();
            int secondNum = int.Parse(number2);

            Console.WriteLine("Before swapping the first number is = " + firstNum + " and the second number is = " + secondNum);

            firstNum = firstNum + secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;

            //Outcome

            Console.WriteLine("After swapping the first number is = " + firstNum + " and the second number is = " + secondNum);
            Console.Read();          
        }
    }
}
