using System;

namespace Homework03_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****SumOfEven*******");

            int i, sum = 0;
            int[] arrInt = new int[6];

            Console.Write("Please enter six integers: ");

            for (i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 6; i++)
            {
                if (arrInt[i] % 2 == 0)
                {
                    sum = sum + arrInt[i];
                }
                
            }
            Console.WriteLine("The sum of the even integers entered is:" + sum);

            }
        }
    }
