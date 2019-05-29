using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindV2
{
    class Program
    {
        
        const int allowedAttempts = 4;
        const int codeLength = 2;
        static string[] secret = new string[codeLength];
        static string[] colorArray = new string[] { "Red", "Yellow", "Blue" };
        static string[] correctPositionCount = new string[0];
        public static int correctPostitionCount;
        public static int correctPostionCount;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            for(int i=0; i <2; i++)
            {
                secret[i] = colorArray[rnd.Next(0, 2)];
            }
            Console.WriteLine("Enter your guess:");
            string[] guess = Console.ReadLine().Split(' ');

            int correctColorCount = 0;
            int correctPositionCount = 0;
            if (secret.Contains(guess[0]))
            {
                correctColorCount++;
            }
            if (secret.Contains(guess[1]))
            {
                correctColorCount++;
            }
            if (guess[0] == secret[0])
            {
                correctPostitionCount++;
            }
            if(guess[1] == secret[1])
            {
                correctPostionCount++;
            }
            Console.WriteLine("Your hint is" + correctColorCount + "-" + correctPositionCount);
        }
        
    }
}
