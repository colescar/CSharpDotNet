using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name, or 'quit' to finish:");
            string name = Console.ReadLine();
            Dictionary<string, string> studentGrade =
           new Dictionary<string, string>();
            while (name != "quit")
            {
                Console.WriteLine("Enter Studnets Grade");
                string grade = Console.ReadLine();
                studentGrade.Add(name, grade);
                Console.WriteLine("Enter student's name, or 'quit' to finish:");
                name = Console.ReadLine();
            }
            //now the user entered quit, we need to calculate the grades
            //we 
            foreach (var i in studentGrade.Keys)
            {
                string g = studentGrade[i];
                //output the students name
                Console.WriteLine($"Name:{i}");
                Console.WriteLine($"Grades:{studentGrade[i]}");
                Console.Read();
            }
            string sName;
            string sGrades;
            string[] arrayGrades;
            int[] iGrades;
            int lowestGrade, highestGrade;

            foreach (var i in studentGrade.Keys)
            {
                sName = i;
                sGrades = studentGrade[i]; // it is like "100 99 98"
                arrayGrades = sGrades.Split('  ');
                iGrades = Array.ConvertAll(arrayGrades, int.Parse);
                Array.Sort(iGrades);
                lowestGrade = iGrades[0];
                highestGrade = iGrades[iGrades.Length - 1];

            }
           
            
            
            Console.Read();
        }
    }
}
