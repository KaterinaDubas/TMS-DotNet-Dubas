using System;
using System.Collections.Generic;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStop = false;
            var backlog = new List<ToDo>();
            InputTask (backlog, inputStop);
            ShowBacklog(backlog);
            ChangeTaskStatus(backlog, inputStop);
            ShowBacklog(backlog);

            Console.ReadLine();
        }

        private static bool InputStop()
        {
            Console.WriteLine("If you want to stop press S/s");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.S;
        }

        private static void InputTask (List<ToDo> backlog, bool inputStop)
        {
            while (!inputStop)
            {
                Console.WriteLine("Enter name and description of the task");
                var todo = new ToDo
                {
                    Name = Console.ReadLine(),
                    Description = Console.ReadLine()
                };
                backlog.Add(todo);
                inputStop = InputStop();
                Console.WriteLine();
            }
        }

        
        private static void ChangeTaskStatus(List<ToDo> backlog, bool inputstop)
        {
            while (!inputstop)
            {
                Console.WriteLine("Enter todo ID");
                var userInput = Console.ReadLine();
                foreach (var todo in backlog)
                {
                    if (todo.GetId() == userInput)
                    {
                        Console.WriteLine("Enter new todo status");
                        Console.WriteLine("Availiable status: InProfress, Done, Canceled");
                        var newStatus = Console.ReadLine();
                        todo.SetStatus(todo.ConvertStatus(newStatus));
                    }
                }
                inputstop = InputStop();
                Console.WriteLine();
            }
        }

        private static void ShowBacklog(List<ToDo> backlog)
        {
            Console.WriteLine("---------");
            foreach (var todo in backlog)
            {
                todo.GetInfo();
            }
            Console.WriteLine("--------");
        }
    }
}
