using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration_PracticeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

        }
        static void MainMenu()
        {
            Console.WriteLine("/--------------------Welcome to While Loop Game------------------------/ \n");
            Console.WriteLine("Pick a game: \n");
            Console.WriteLine("1.) Print Numbers");
            Console.WriteLine("2.) Guessing Game");
            Console.WriteLine("3.) Exit");
            Console.Write("\nEnter your choice: ");
            int result = Convert.ToInt32(Console.ReadLine());

            if (result == 1)
            {
                PrintNumbers();
            }
            else if (result == 2)
            {
                GuessingGame();
            }

            else if (result == 3)
            {
                Console.Clear();
                Console.WriteLine("You have choosen to exit!\n");
                Console.WriteLine("Goodbye!!!");
            }
        }

        static void PrintNumbers()
        {
            Console.Clear();
            Console.Write("Enter a number: ");

            int result = int.Parse(Console.ReadLine());
            int counter = 0;
            Console.WriteLine($"\nHere is the print out of the number: {result}");
            while (counter < result)
            {
                Console.Write(counter + 1 + "-");
                counter++;

            }
            Console.Write("\n\nPress 'Esc' key to return to Main Menu or press 'Enter' to play again: ");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                PrintNumbers();
            }
            else if (cki.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                MainMenu();
            }


        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!\n");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 10);

            int guesses = 0;//intitializing guesses to keep track of how many tries it took the user
            bool incorrect = true;

            do//do while iteration statement used to ask user to make guesses untill they are correct 
            //do while iteration statement allows you to run the code at least once 
            {
                Console.Write("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;//incrementing the number of guesses for each try
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("\nWrong!\n");
                }
            }
            while (incorrect);
            {
                Console.WriteLine($"\nCorrect! It took you {guesses} tries!");
                Console.ReadLine();
            }


        }


    }
}
