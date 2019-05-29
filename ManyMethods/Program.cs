using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            oddevent();
            
            Console.ReadLine();
        }
        public static void hello()
        {
            Console.WriteLine("Hello! What's your name?");
            String input = Console.ReadLine();
            Console.WriteLine("Bye " + input);
        }
        public static void addition()
        {
            String N1 = Console.ReadLine();
            String N2 = Console.ReadLine();
            int num1 = Convert.ToInt32(N1);
            int num2 = Convert.ToInt32(N2);
            Console.WriteLine(num1 + num2);
        }
        public static void catdog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            String animal = Console.ReadLine();
            
            if(animal == "cat")
            {
                Console.WriteLine("meow");
            }else
            {
                Console.WriteLine("woof");
            }
            
           
        }
        public static void oddevent()
        {
            Console.WriteLine("Is your number even or odd?");
            String number = Console.ReadLine();

            if(number == "2 , 4 , 6 , 8 , 0")
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public static void inches()
        {
            Console.WriteLine("Foot to Inches");
            String input = Console.ReadLine();

            String N1 = Console.ReadLine();
            String N2 = Console.ReadLine();
            Convert  

        }
        public static void echo()
        {
            Console.WriteLine("Echo Words");

        }
        public static void killagram()
        {
            Console.WriteLine("Convert LB to KG");
            String number = Console.ReadLine();
            String N1 = Console.ReadLine();
            String N2 = Console.ReadLine();
            if {
                N1 == 1
            } 
            else
            {
                N2 == 2.2
            }
        }
        public static void date()
        {
            Console.WriteLine("Show Date");
        }

        public static void age()
        {
            Console.WriteLine("What year were you born?");

        }
        
        public static void guess()
        {
            Console.WriteLine("Guess the Word");

        }
    }
}
