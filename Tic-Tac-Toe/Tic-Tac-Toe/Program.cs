using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        public static char[] BoardNum = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static int Player1;
        public static int Player2;

        static void Main(string[] args)
        {
            Board();
            Game();

        }

        public static void Board()
        {

            Console.WriteLine(@" {0} | {1} | {2}", BoardNum[1], BoardNum[2], BoardNum[3]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(@" {0} | {1} | {2}", BoardNum[4], BoardNum[5], BoardNum[6]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(@" {0} | {1} | {2}", BoardNum[7], BoardNum[8], BoardNum[9]);
            Console.Write("\n \n");

        }

        public static void Game()

        {
            int numofGames = 0;

            while (numofGames < 5)
            {
                FirstPlayer();
                Console.Clear();
                Board();
                AnyWinner();
                SecondPlayer();
                Console.Clear();
                Board();
                AnyWinner();

                numofGames++;


            }




        }

        public static void FirstPlayer()
        {
            Console.Write("*Player 1* Enter 1-9:  ");
            Player1 = int.Parse(Console.ReadLine());
            switch (Player1)
            {
                case 1:
                    BoardNum[1] = 'X';
                    break;
                case 2:
                    BoardNum[2] = 'X';
                    break;
                case 3:
                    BoardNum[3] = 'X';
                    break;
                case 4:
                    BoardNum[4] = 'X';
                    break;
                case 5:
                    BoardNum[5] = 'X';
                    break;
                case 6:
                    BoardNum[6] = 'X';
                    break;
                case 7:
                    BoardNum[7] = 'X';
                    break;
                case 8:
                    BoardNum[8] = 'X';
                    break;
                case 9:
                    BoardNum[9] = 'X';
                    break;

            }

        }

        public static void SecondPlayer()
        {
            Console.Write("*Player 2* Enter 1-9: ");
            Player2 = int.Parse(Console.ReadLine());


            switch (Player2)
            {
                case 1:
                    BoardNum[1] = 'O';
                    break;
                case 2:
                    BoardNum[2] = 'O';
                    break;
                case 3:
                    BoardNum[3] = 'O';
                    break;
                case 4:
                    BoardNum[4] = 'O';
                    break;
                case 5:
                    BoardNum[5] = 'O';
                    break;
                case 6:
                    BoardNum[6] = 'O';
                    break;
                case 7:
                    BoardNum[7] = 'O';
                    break;
                case 8:
                    BoardNum[8] = 'O';
                    break;
                case 9:
                    BoardNum[9] = 'O';
                    break;

            }



        }

        public static void AnyWinner()
        {
            if (DidPlayer1Win() == true)
            {
                Console.WriteLine("Player 1 Won");
                Console.ReadLine();

            }
            else if (DidPlayer2Win() == true)
            {
                Console.WriteLine("Player 2 Won");
                Console.ReadLine();


            }

        }
        public static bool DidPlayer1Win()
        {
            if ((BoardNum[1] == 'X' && BoardNum[2] == 'X' && BoardNum[3] == 'X') || //row 1 
                (BoardNum[4] == 'X' && BoardNum[5] == 'X' && BoardNum[6] == 'X') || //row 2
                (BoardNum[7] == 'X' && BoardNum[8] == 'X' && BoardNum[9] == 'X') || //row 3

                (BoardNum[1] == 'X' && BoardNum[4] == 'X' && BoardNum[7] == 'X') || //col 1
                (BoardNum[2] == 'X' && BoardNum[5] == 'X' && BoardNum[6] == 'X') || //col 2
                (BoardNum[3] == 'X' && BoardNum[6] == 'X' && BoardNum[9] == 'X') || //col 3

                (BoardNum[1] == 'X' && BoardNum[5] == 'X' && BoardNum[9] == 'X') || //diag 1
                (BoardNum[3] == 'X' && BoardNum[5] == 'X' && BoardNum[7] == 'X'))   //diag 2

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DidPlayer2Win()
        {
            if ((BoardNum[1] == 'O' && BoardNum[2] == 'O' && BoardNum[3] == 'O') || //row 1 
                (BoardNum[4] == 'O' && BoardNum[5] == 'O' && BoardNum[6] == 'O') || //row 2
                (BoardNum[7] == 'O' && BoardNum[8] == 'O' && BoardNum[9] == 'O') || //row 3

                (BoardNum[1] == 'O' && BoardNum[4] == 'O' && BoardNum[7] == 'O') || //col 1
                (BoardNum[2] == 'O' && BoardNum[5] == 'O' && BoardNum[6] == 'O') || //col 2
                (BoardNum[3] == 'O' && BoardNum[6] == 'O' && BoardNum[9] == 'O') || //col 3

                (BoardNum[1] == 'O' && BoardNum[5] == 'O' && BoardNum[9] == 'O') || //diag 1
                (BoardNum[3] == 'O' && BoardNum[5] == 'O' && BoardNum[7] == 'O'))   //diag 2

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
            if (DidPlayer1Win() == false && DidPlayer2Win() == false)
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
