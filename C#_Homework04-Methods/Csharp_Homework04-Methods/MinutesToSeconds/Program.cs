using System;

namespace MinutesToSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many minutes you wish to convert to seconds: ");
            int minutes = 0;
            bool isMinutesValidInteger = int.TryParse(Console.ReadLine(), out minutes);

            ConvertMinutes(minutes);

            static int ConvertMinutes(int minutes)
            {
                int seconds = 60;
                int minutesToseconds = seconds * minutes;
                Console.WriteLine($"Entered minutes: {minutes} converted in seconds are exactly {minutesToseconds} seconds.");
                return minutesToseconds;
            }
        }
    }
}
        
    

