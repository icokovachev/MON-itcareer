using System;

namespace Square_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            string stars = "*";
            string emptyField = " ";

            RowOfStars(userInput, stars);

            for (int i = 1; i <= userInput - 2 ; i++)
            {
                Console.Write(stars);
                for (int j = 0; j < userInput - 2; j++)
                {
                    Console.Write(emptyField);
                }
                Console.WriteLine(stars);
            }

            RowOfStars(userInput, stars);
        }

        static void RowOfStars(int userInput, string stars)
        {
            for (int i = 1; i <= userInput; i++)
            {
                Console.Write(stars);
            }
            Console.WriteLine();
        }
    }
}
