using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bookinventory
{
    class Program
    {
        static BookContext _context = new BookContext();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the Author");
            string author = Console.ReadLine();
            Book toAdd = new Book();
            toAdd.author = author;
            toAdd.title = title;

            _context.Add(toAdd);

            IEnumerable<Book> books = _context.books;





        }
        


    }
    


}
