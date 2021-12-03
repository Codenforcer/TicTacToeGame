// See https://aka.ms/new-console-template for more information
using System;

namespace TicTacToe
{
    class Program
    {

        // Create the playfield, Create arrays matching the 9 positions on the board.
        static char[,] playField =
        {
            {'1', '2', '3'}, // Row 1
            {'4', '5', '6'}, // Row 2
            {'7', '8', '9'}  // Row 3
        };

        static void Main(string[] args)
        {

            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            SetField();


            do
            {

                if (player == 2)
                {
                    player = 1;
                    playerXOrO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    playerXOrO(player, input);
                }

                do
                {
                    Console.Write("\nPlayer {0}: Choose your field! ", player);
                    input = Convert.ToInt32(Console.ReadLine());
                }
                while (!inputCorrect);
                {

                }

                    
            


            } while (true);

        }

        // Create a new method, that sets up the tictactoe board..
        public static void SetField()
        {

            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |    ");
            
            
        }

        // Below method dictates if player(X) or player (O).
        public static void playerXOrO(int player, int input)
        {
            // If/else statement to determine which player is X or O on move.
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input) // Switch statement for every possible move a player can make.
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }

        }
    }
}
