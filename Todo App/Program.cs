using System;
using Todo_App;

namespace Todo_App {

    class Program
    {
        static void Main(string[] args) {

            var todoList = new TodoList();
            string command;

            Console.WriteLine("welcome To my TodoApp");

            do
            {
                Console.WriteLine("\nAvailable Commands: \n1 Add \n2 Remove \n3 Complete \n4 List \n5 Exit");
                Console.Write("Enter a command ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "1":
                        Console.Write("Enter the description ");
                        var description = Console.ReadLine();
                        todoList.AddTodoItem(description);
                        break;

                    case "2":
                        Console.Write("Enter the ID of the item to remove ");
                        if (int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            todoList.RemoveTodoItem(removeId);
                        }
                        break;

                    case "3":
                        Console.Write("Enter the ID of the item to complete ");
                        if (int.TryParse(Console.ReadLine(), out int completeId))
                        {
                            todoList.MarkTodoItemAsCompleted(completeId);
                        }
                        break;

                    case "4":
                        todoList.ListTodoItems();
                        break;
                }
            } while (command != "5");

            Console.WriteLine("Goodbye!");
        }
    }

}

