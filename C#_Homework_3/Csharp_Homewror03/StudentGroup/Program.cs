using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Student Group*******");

            string[] G1 = new string[] 
            { 
                "Ana",
                "Atanas",
                "Zorica",
                "Lena",
                "Dimitar",
                "Milica",
                "Marija",
                "Suzana" 
            };

            string[] G2 = new string[] 
            { 
                "Ena", 
                "Aleksandar",
                "Velko", 
                "Kosta", 
                "Marko", 
                "Lazar", 
                "Nikola", 
                "Filip" };

            Console.WriteLine("Please choose student group, enter 1 for G1 group, enter 2 for G2 group: ");

            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("The students from G1 student group are: " + "\n" + G1[0] + "\n" + G1[1] + "\n" + G1[2] + "\n" + G1[3] + "\n" + G1[4] + "\n" + G1[5] + "\n" + G1[6] + "\n" + G1[7]);
            }
            else if (userInput == 2)
            {
                Console.WriteLine("The students from G2 student group are: " + "\n" + G2[0] + "\n" + G2[1] + "\n" + G2[2] + "\n" + G2[3] + "\n" + G2[4] + "\n" + G2[5] + "\n" + G2[6] + "\n" + G2[7]);
            }
            else
            {
                Console.WriteLine("Please instert number 1 or number 2 only!");
            }
        }
    }
}
