using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Towers_of_Hanoi
{
    class Program
    {
        static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            board.Add("A", new Stack<int>());
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());
            for(int i = 3; i>0; i--)
            {
                board["A"].Push(i);
            }
           while(board["C"].Count < 3)
            {
                PrintGame();
                Console.WriteLine("Enter Your Move");
                string inp = Console.ReadLine();
                string[] moves = inp.Split(' ');
                moves[0] = moves[0].ToUpper();
                moves[1] = moves[1].ToUpper();
                if (!move(moves))
                {
                    Console.WriteLine("Invalid Move");
                }
                

            }
            PrintGame();
            Console.WriteLine("You Won!");
            Console.ReadLine();
        }
        public static bool move(string[] moves)
        {
            if(board[moves[1]].Count == 0 || board[moves[0]].Peek() < board[moves[1]].Peek())
            {
                board[moves[1]].Push(board[moves[0]].Pop());
                return true;
            }
            return false;
        }
        public static void PrintGame()
        {
            Console.WriteLine();
            Console.Write("A: ");
            int[] reverse=new int[board["A"].Count];
            int count = reverse.Length - 1;
            foreach(int num in board["A"])
            {
                reverse[count] = num;
                count--;

            }
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i]+" ");
            }


            Console.WriteLine();
            Console.Write("B: ");
            reverse = new int[board["B"].Count];
            count = reverse.Length - 1;
            foreach (int num in board["B"])
            {
                reverse[count] = num;
                count--;

            }
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }

            Console.WriteLine();
            Console.Write("C: ");
            reverse = new int[board["C"].Count];
            count = reverse.Length - 1;
            foreach (int num in board["C"])
            {
                reverse[count] = num;
                count--;

            }
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }
            Console.WriteLine();
        }
    }


    }

