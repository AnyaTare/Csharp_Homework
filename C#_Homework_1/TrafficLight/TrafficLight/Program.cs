using System;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            // class exercise 1

            Console.WriteLine("             ");
            Console.WriteLine("        *");
            Console.WriteLine("       * *");
            Console.WriteLine("      * * *");
            Console.WriteLine("     * * * *");
            Console.WriteLine("    * * * * *");
            Console.WriteLine("   * * * * * *");
            Console.WriteLine("       |||");

            Console.WriteLine("******************************");
            // class exercise 2

            Console.WriteLine("            ");
            Console.WriteLine("       *");
            Console.WriteLine("       *");
            Console.WriteLine("     * * *");
            Console.WriteLine("   *   *   *");
            Console.WriteLine("       *");
            Console.WriteLine("       *");
            Console.WriteLine("     *   *");
            Console.WriteLine("   *       *");

            Console.WriteLine("******************************");


            // Homework01
            Console.BackgroundColor
            = ConsoleColor.Red;
            Console.WriteLine("STOP", Console.BackgroundColor);

            Console.BackgroundColor
         = ConsoleColor.Yellow;
            Console.WriteLine("READY", Console.BackgroundColor);

            Console.BackgroundColor
            = ConsoleColor.Green;
            Console.WriteLine("GO!", Console.BackgroundColor);

            Console.BackgroundColor
                = ConsoleColor.Black;
            Console.WriteLine("",Console.BackgroundColor);


        }
    }
}
