using System;
using System.Collections.Generic;
using System.Linq;

namespace Todo_App
{
    public class TodoList
    {
        private List<TodoItem> _items = new List<TodoItem>();
        private int _nextId = 1;

        public void AddTodoItem(string description)
        {
            var item = new TodoItem { ID = _nextId++, Description = description, IsCompleted = false };
            _items.Add(item);
        }

        public void RemoveTodoItem(int id)
        {
            var item = _items.FirstOrDefault(i => i.ID == id);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public void MarkTodoItemAsCompleted(int id)
        {
            var item = _items.FirstOrDefault(i => i.ID == id);
            if (item != null)
            {
                item.IsCompleted = true;
            }
        }

        public void ListTodoItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
