/*
    Todo:

    print board
    change player turn and
    get input
    check winner

    winner fields:
    012 
    345
    678
    056
    147
    258
    048
    246
*/

using System; 

namespace TicTacToe
{
    public class TicTacToe
    {
        static string[] board = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};
        static string player = "X";
        static string input = "";

        static bool thereWinner = false;


        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Jogo da Velha!");

            do
            {
                PrintStart();
                

                RegisterMove();

                if (thereWinner)
                {
                    PrintStart();
                    Console.WriteLine($"Jogador {player} venceu!");
                    Environment.Exit(0);
                }
                
                SwitchPLayer(player);

            } while (!thereWinner);
        }

        public static void PrintStart()
        {
            Console.Clear();
            Console.WriteLine($"Essa é a vez do jogador {player}");
            Console.WriteLine("Selecione um campo pelo número correspondente!");
            PrintBoard();
        }

        public static void CheckWinner()
        {
            string field = player;


            if (board[0] == field && board[1] == field && board[2] == field)
            {
                thereWinner = true;
            }
            if (board[3] == field && board[4] == field && board[5] == field)
            {
                thereWinner = true;
            }
            if (board[6] == field && board[7] == field && board[8] == field)
            {
                thereWinner = true;
            }
            if (board[0] == field && board[3] == field && board[6] == field)
            {
                thereWinner = true;
            }
            if (board[1] == field && board[4] == field && board[7] == field)
            {
                thereWinner = true;
            }
            if (board[2] == field && board[5] == field && board[8] == field)
            {
                thereWinner = true;
            }
            if (board[0] == field && board[4] == field && board[8] == field)
            {
                thereWinner = true;
            }
            if (board[2] == field && board[4] == field && board[6] == field)
            {
                thereWinner = true;
            }
        }

        public static void RegisterMove()
        {
            input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    board[0] = player;
                    break;
                case "1":
                    board[1] = player;
                    break;
                case "2":
                    board[2] = player;
                    break;
                case "3":
                    board[3] = player;
                    break;
                case "4":
                    board[4] = player;
                    break;
                case "5":
                    board[5] = player;
                    break;
                case "6":
                    board[6] = player;
                    break;
                case "7":
                    board[7] = player;
                    break;
                case "8":
                    board[8] = player;
                    break;

                default:
                    Console.WriteLine("Entrada invalida! Selecione um dos campos do tabuleiro.");
                    RegisterMove();
                    break;
            }

            

            CheckWinner();
        }

        public static void PrintBoard()
        {
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        public static void SwitchPLayer(string playerNow)
        {
            if (playerNow == "X")
            {
                player = "O";
            }
            else
            {
                player = "X";
            }
        }
    }
}