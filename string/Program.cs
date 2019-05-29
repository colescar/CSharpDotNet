using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        public static object tempWord { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Find the Longest string");
            //prompt user to enter a long sentence
            Console.WriteLine("Enter a sentence and I will find the longest word in it");
            //store users sentence
            string userSentence = Console.ReadLine().Trim();

            //logic
            //split sencetence into individual words
            string[] userWords = userSentence.Split(' ');

            //remove punctuation
            // we need a char array for all punctuation symbols 
            char[] punctuation = new char[] { };
            // let us loop through the words array and remove puntuation from each word
            string longestWord = "";
            int wordLength = 0;
            foreach (string word in userWords)
            {
                for (int i = 0; i < punctuation.Length; i++) ;
            }
            //now we removed punctuation
            if (tempWord.Length > longestWord.Length)
            {
                longestWord = tempWord;

            }
            wordLength = longestWord.Length;
    
        }


        Console.WriteLine($"Longest word is '(longestWord)','(wordLength)';

    }
}
