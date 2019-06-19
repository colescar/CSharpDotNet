using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static string[,] board = new string[3, 3];
        static bool gameOver = false;
        static bool xTurn = true;
        static string winner;

        public static void Main(String[] args)
        {
            //initialize the board
            for(int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    board[i, x] = " ";
                }
            }

            while (!gameOver)
            {
                PrintGame();
                Console.WriteLine("Enter the Column and Row (1 2)");
                string moves = Console.ReadLine();
                int row = Convert.ToInt16(moves.Split(' ')[1]) - 1;
                int col = Convert.ToInt16(moves.Split(' ')[0]) - 1;
                if (!move(row, col))
                {
                    continue;
                }
                isGameOver();
            }
            PrintGame();
            Console.WriteLine("Winner is " + winner);
            Console.ReadLine();
        }
        static bool move(int row, int col)
        {
            if (board[row, col]==" ")
            {
                if (xTurn)
                {
                    board[row, col] = "x";
                }
                else
                {
                    board[row, col] = "o";
                }
                xTurn = !xTurn;
                return true;
            }
            return false;
        }
        static void PrintGame()
        {
            Console.WriteLine("   1  2  3");
            for(int x = 0; x < 3; x++)
            {
                Console.Write((x + 1) + " ");
                for(int y = 0; y < 3; y++)
                {
                    Console.Write("[" + board[x, y] + "]");
                }
                Console.WriteLine();
            }
        }
        static void isGameOver()
        {
            //check rows
            for (int y = 0; y < 3; y++)
            {
                int count = 0;
                for(int x= 0; x <3; x++)
                {
                    if (board[y, x] == "x")
                    {
                        count++;
                    }
                    else if (board[y, x] == "o")
                    {
                        count--;
                    }
                    
                }
                if (count == 3)
                {
                    winner = "x";
                    gameOver = true;
                }
                else if (count == -3)
                {
                    winner = "o";
                    gameOver = true;
                }
            }
            //check the columns
            for (int y = 0; y < 3; y++)
            {
                int count = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (board[x, y] == "x")
                    {
                        count++;
                    }
                    else if (board[x, y] == "o")
                    {
                        count--;
                    }

                }
                if (count == 3)
                {
                    winner = "x";
                    gameOver = true;
                }
                else if (count == -3)
                {
                    winner = "o";
                    gameOver = true;
                }
            }
            //czech diagonals
            if(board[0,0] != " " && board[0,0] == board[1,1] && board[1,1] == board[2, 2])
            {
                if (board[0, 0] == "x")
                {
                    winner = "x";
                    gameOver = true;
                }
                else if (board[0, 0] == "o")
                {
                    winner = "o";
                    gameOver = true;
                }
            }
            if(board[0,2]!=" "&& board[0,2]== board[1,1] && board[1,1]== board[2, 0])
            {
                if (board[0, 2] == "x")
                {
                    winner = "x";
                    gameOver = true;
                }
                else if (board[0, 2] == "o")
                {
                    winner = "o";
                    gameOver = true;
                }
            }


        }
    }
}

