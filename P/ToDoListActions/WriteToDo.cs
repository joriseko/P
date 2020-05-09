using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P
{
    class WriteToDo
    {


        public void AddTask()
        {
            Console.WriteLine("Add task (task[,] and Status 0 - Not Completed, 1 - Completed, 2 - Unknown: )");
            string newTask=Convert.ToString(Console.ReadLine());
            File.AppendAllText("ToDoList.txt", Environment.NewLine + newTask );

        }


    }
}
