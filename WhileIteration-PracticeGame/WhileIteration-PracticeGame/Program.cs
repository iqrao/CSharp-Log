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
            bool displayMenu = true;
            while (displayMenu)//while iteration statement used to display the menu repeatedly untill user exits
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1.) Option 1: Print Numbers");
            Console.WriteLine("2.) Option 2: Guessing Game");
            Console.WriteLine("3.) Exit Game");
            Console.Write("Enter your choice: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }

            else if (result == "2")
            {
                GuessingGame();
                return true;
            }

            else if (result == "3")
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
                return false;
            }

            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            //Prints the numbers starting from 0 up till the user input.
            Console.Clear();
            Console.WriteLine("Print Numbers\n");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)//while iteration used to print values to a screen based on value entered by user
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }

            Console.ReadLine();

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
