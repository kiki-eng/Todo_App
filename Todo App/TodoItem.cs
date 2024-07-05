using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_App
{
    public class TodoItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{ID}: {Description}  - {(IsCompleted ? "Cpmpleted" : "Pending")}";
        }
    }
}
