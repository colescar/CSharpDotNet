using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] choices = { "rock", "paper", "scissors" };
            while (true)
            {
                int cpuChoice = rand.Next(0, 3);
                string cpu = choices[cpuChoice];
                Console.WriteLine("Enter Your Choice");
                string userChoice = Console.ReadLine();
                if (!choices.Contains(userChoice))
                {
                    break;
                }
                Console.WriteLine("cpu chose " + cpu);
                Console.WriteLine(whoWon(userChoice, cpu));

                
            }
            
        }
        static string whoWon(string user, string cpu)
        {
            if(user == "rock")
            {
                if(cpu == "rock")
                {
                    return "it's a tie!";
                }
                if(cpu == "scissors")
                {
                    return "You Win!";
;               }
                if(cpu == "paper")
                {
                    return "You Lose!";
                }
            }
            if (user == "scissors")
            {
                if (cpu == "rock")
                {
                    return "You Lose!";
                }
                if (cpu == "scissors")
                {
                    return "It's a Tie!";
                    ;
                }
                if (cpu == "paper")
                {
                    return "You Win!";
                }
            }
            if (user == "paper")
            {
                if (cpu == "rock")
                {
                    return "You Win!";
                }
                if (cpu == "scissors")
                {
                    return "You Lose!";
                    ;
                }
                if (cpu == "paper")
                {
                    return "It's a Tie!";
                }

            }
            return "error";

        }
    }
}
