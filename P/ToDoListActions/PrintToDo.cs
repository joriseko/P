using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace P
{
    class PrintToDo
    {

        ReadToDo readToDo = new ReadToDo();
        static string mainToDotxt = "ToDoList.txt";
        string[] myToDoListToString = File.ReadAllLines(mainToDotxt);
        
        public void Print()
        {
            foreach (var task in myToDoListToString)
            {
                readToDo.PrintAll(task);
            }
        }

        public void PrintCompleted()
        {
            foreach(var task in myToDoListToString)
            { 
                readToDo.SortCompleted(task);
            }
        }

        public void PrintNotCompleted()
        {
            foreach (var task in myToDoListToString)
            {
                readToDo.SortNotCompleted(task);
            }
        }
        public void PrintUnknown()
        {
            foreach (var task in myToDoListToString)
            {
                readToDo.SortUnknown(task);
            }
        }

        public void PrintToFileDeleteCompleted()
        {
            string notepadWOutCompleted = "ToDoWithoutCompleted.txt";
            File.WriteAllText("ToDoWithoutCompleted.txt", string.Empty);
            foreach (var task in myToDoListToString)
            {
                readToDo.DeleteCompleted(task);
            }
            Process.Start("notepad.exe", notepadWOutCompleted);
        }


        public void PrintAllChangingStatus()
        {
            string notepadChangedStatus = "ToDoListChangeState.txt";
            File.WriteAllText("ToDoListChangeState.txt", string.Empty);
            foreach (var task in myToDoListToString)
            {
                readToDo.RunThroughAllnChangeStatus(task);
            }

        }



    }
}
