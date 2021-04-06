using System;

namespace WinsDrawsLoses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of the wins: ");
            bool checkTheWins = long.TryParse(Console.ReadLine(), out long wins);

            Console.WriteLine("Please enter the number of the draws: ");
            bool checkTheDraws = long.TryParse(Console.ReadLine(), out long draws);

            Console.WriteLine("Please enter the number of the losses: ");
            bool checkTheLosses = long.TryParse(Console.ReadLine(), out long losses);


            long result = Points(wins, draws, losses);
            Console.WriteLine($"This team has scored a total of {result} points");

            static long Points(long wins, long draws, long losses)
            {
                long winsPoints = wins * 3;
                long drawsPoints = draws * 1;
                long lossesPoints = losses * 0;

                return winsPoints + drawsPoints + lossesPoints;
            }

            //why cant short be used here?

            //Console.WriteLine("Please enter the number of the wins");
            //bool checkTheWins = long.TryParse(Console.ReadLine(), out long wins);

            //Console.WriteLine("Please enter the number of the wins");
            //bool checkTheDraws = long.TryParse(Console.ReadLine(), out long draws);

            //Console.WriteLine("Please enter the number of the wins");
            //bool checkTheLosses = long.TryParse(Console.ReadLine(), out long losses);


            //long result = Points(wins, draws, losses);
            //Console.WriteLine($"This team has scored a total of {result} points");

            //static int Points(long wins, long draws, long losses)
            //{
            //    long winsPoints = wins * 3;
            //    long drawsPoints = draws * 1;
            //    long lossesPoints = losses * 0;

            //    return winsPoints + drawsPoints + lossesPoints;
            //}
        }
    }
}
