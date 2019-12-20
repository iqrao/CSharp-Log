using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static public char player = (char)0;
        static public char computer;

        public static void Main(string[] args)

        {
            int numofGames = 0;
            int playerwin = 0;
            int computerwin = 0;
            int draw = 0;


            StartDisplay();

            Console.Write("Enter how many games do you want to play? ");

            int howManyGames = int.Parse(Console.ReadLine());



            for (int i = 1; i <= howManyGames; i++)
            {
                if (i == 1)
                {
                    Console.Write("\n\nYou Go First! Enter Your Option(P,R or S): ");



                }
                else
                {
                    Console.WriteLine("\n\nPlay Again!");
                    Console.Write("Enter Your Option(P,R or S): ");
                }


                Game();

                numofGames++;

                if (DidPlayerWin() == true)
                {
                    playerwin++;

                }

                if (DidComputerWin() == true)
                {
                    computerwin++;

                }

                if (Draw() == true)
                {
                    draw++;

                }

            }


            Console.WriteLine($"\n\nYou played {numofGames} games!\n");
            Console.WriteLine($"Draw: {draw}\nPlayer Wins: {computerwin}\nComputer Wins: {playerwin}");
            Console.ReadLine();

        }

        public static void StartDisplay()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************\n");
            Console.WriteLine("  WELCOME TO ROCK, PAPER, SCISSORS\n");
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************\n");

        }

        public static void Game()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            while (true)
            {

                switch (cki.Key)
                {
                    case ConsoleKey.P:
                        player = 'P';
                        goto Done;
                    case ConsoleKey.R:
                        player = 'R';
                        goto Done;
                    case ConsoleKey.S:
                        player = 'S';
                        goto Done;
                    default:
                        Console.Beep();
                        break;
                }

            }
        Done: Console.WriteLine($"\nPlayer: {player}");



            Random myRandom = new Random();
            char[] PRS = { 'P', 'R', 'S' };
            int index = myRandom.Next(PRS.Length);

            computer = PRS[index];

            string message = "";

            //Tie 
            if (player == 'P' && computer == 'P'
                || player == 'R' && computer == 'R'
                || player == 'S' && computer == 'S')
            {

                Console.Write($"Computer: {computer}");

                message += "\nTie!";

            }

            ///// Paper vs Scissors: Scissors Win
            else if (player == 'P' && computer == 'S')
            {
                Console.Write($"Computer: {computer}");
                Console.Write("\nComputer Win! Scissors");
            }
            else if (player == 'S' && computer == 'P')
            {
                Console.Write($"Computer: {computer}");
                Console.Write("\nYou Win! Scissors!");
            }

            // Paper vs Rock: Paper Wins
            else if (player == 'P' && computer == 'R')
            {
                Console.Write($"Computer: {computer}");
                Console.Write("\nYou Win! Paper");
            }
            else if (player == 'R' && computer == 'P')
            {
                Console.Write($"Computer: {computer}");
                Console.Write("\nComputer Wins! Paper");
            }

            // Scissors vs Rock: Rock Wins
            else if (player == 'S' && computer == 'R')
            {

                Console.Write($"Computer: {computer}");
                //message += "";
                Console.Write("\nComputer Wins! Rock");
            }
            else if (player == 'R' && computer == 'S')
            {
                Console.Write($"Computer: {computer}");
                Console.Write("\nYou Win! Rock");
            }
            else
            {
                Console.Write("Error, enter P,R,S");
            }

            Console.Write(message);

        }


        public static bool DidComputerWin()
        {
            if (player == 'P' && computer == 'S' ||
                player == 'R' && computer == 'P' ||
                player == 'S' && computer == 'R')
                return true;
            {
                return false;
            }
        }

        public static bool DidPlayerWin()
        {

            if (((player == 'S' && computer == 'P' ||
                (player == 'P' && computer == 'R') ||
                (player == 'R' && computer == 'S'))))
            {

                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool Draw()
        {
            if (player == 'P' && computer == 'P' ||
                player == 'R' && computer == 'R' ||
                player == 'S' && computer == 'S')
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }

}























