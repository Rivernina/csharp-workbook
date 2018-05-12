using System;

namespace TicTacToe
{
    class Program
    {
        
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {

         Console.WriteLine("\n{0,50}", "*****************************************");
         Console.WriteLine("");
         Console.WriteLine("{0,45}", "Welcome to Tic-Tac-Toe game!");
         Console.WriteLine("");

         Console.WriteLine("{0,50}", "*****************************************");
         Console.WriteLine(""); 
         Console.WriteLine("");

        //  int row = 0;
        //  int column = 0;
        //  bool CheckForValidMove = false;

            do
            {
                DrawBoard();
                GetInput();

            } 
            while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.Write("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
        }

        public static void PlaceMark(int row, int column)
        {
        // your code goes here
            board[row][column] = playerTurn; 
        }

        // public static bool CheckForValidMove(int row, int column)
        // {
        //     bool  InvalidMove = false;
        //     if (row < 0 || row > 2 || column < 0 || column > 2)
        //     {
        //         Console.WriteLine("Invalid move. Try again.");
        //     }
        //     else if (board[row][column] == "X" || board[row][column] == "O")
        //     {
        //         Console.WriteLine("This cell is already marked");
        //     }
        //     return InvalidMove;

        // }

        public static bool CheckForWin()
        {
            // your code goes here
            
            bool Winner = HorizontalWin() || VerticalWin() || DiagonalWin();
            if (Winner)
            {   
                Console.WriteLine("\n\tCongratulations! You have Won!");
            }
            else if (playerTurn == "X")
            {
                playerTurn = "O";
            }
            else  
            {
                playerTurn = "X";
            }

            return Winner;
        }

        public static bool CheckForTie()
        {
            // your code goes here
            bool Tie = false;
            if (board[0][0] != " " && board[0][1] != " " && board[0][2] != " " && board[1][0] != " " && board[1][1] != " " && board[1][2] != " " && board[2][0] != " " && board[2][1] != " " && board[2][2] != " ")
            {
                Tie = true;
                Console.WriteLine("\n\tIt's a tie! Press any Key to continue.");
            }
            return Tie;
        }
        
        public static bool HorizontalWin()
        {
        // your code goes here
            bool HorizontalWinner = false;
            if (board[0][0] == playerTurn && board[0][1] == playerTurn &&  board[0][2] == playerTurn)
            {
                HorizontalWinner = true;
            }
            if (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn)
            {
                HorizontalWinner = true;
            }
            if (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
            {
                HorizontalWinner = true;
            }

        return HorizontalWinner;
        }

        public static bool VerticalWin()
        {
            // your code goes here
            bool VerticalWinner = false;
            if (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn)
            {
                VerticalWinner = true;
            }
             if (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn)
            {
                VerticalWinner = true;
            }
             if (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
            {
                VerticalWinner = true;
            }
            return VerticalWinner;
        }

        public static bool DiagonalWin()
        {
            // your code goes here
            bool DiagonalWinner = false;
            if (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn)
            {
                DiagonalWinner = true;
            }
            if (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn)
            {
                DiagonalWinner = true;
            }
            return DiagonalWinner;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
