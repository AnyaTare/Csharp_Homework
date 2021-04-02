using System;

namespace Student_Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Student group 2******");

            string[] G1 =
            {
                "Ina",
                "Vasko",
                "Petar",
                "Slavica",
                "Elena"
            };

            string[] G2 =
            {
                "Simona",
                "Violeta",
                "Biljana",
                "Branko",
                "Hristijan"
            };


            Console.WriteLine("Please enter 1 for students of G1 or 2 for students of G2:");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("The students in G1 are:");
                foreach (string student in G1)
                    Console.WriteLine(student);
            }
            else if (userInput == 2)
            {
                Console.WriteLine("The students in G2 are:");
                foreach (string student in G2)
                    Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("Please enter number 1 or 2 only!");
            }


            Console.ReadLine();
        }
    }
}
