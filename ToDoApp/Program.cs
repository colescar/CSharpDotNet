using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{

}

namespace ToDoList___CheckPoint2
{
    public class ToDoItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public ToDoItem(string Description, string Status, DateTime DueDate)
        {
            this.Description = Description;
            this.Status = Status;
            this.DueDate = DueDate;
        }
    }
}