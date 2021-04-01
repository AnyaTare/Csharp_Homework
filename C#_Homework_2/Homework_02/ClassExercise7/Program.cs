using System;

namespace ClassExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick you lucky number from given 1, 2 or 3.");
            string number = Console.ReadLine();
            int luckyguess = int.Parse(number);

            switch (luckyguess)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Darn!! Wishing you better luck next time!");
                    break;
            }
        }
    }
}
