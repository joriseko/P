using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P.ToDoListActions
{
    class SortToDo
    {

        private List<string> dataToSort = new List<string>();
      //  string directory = "ToDoList.txt";
       // string[] myToDoListToString = File.ReadAllLines(directory);

        string[] Completed = ShowCompleted(myToDoListToString);

        public string[] ShowCompleted(string[] myToDoListToString)
        {
            dataToSort = new List<string>();
            foreach(var line in myToDoListToString)
            {
                string[] lineData = line.Split(',');
                if (lineData[1]=="1")
                { dataToSort.Add($"{lineData[0]},{lineData[1]}"); };
            }
            return dataToSort.ToArray();
        }

        public void SCompleted()
        {
            ReadToDo readToDo = new ReadToDo();

            Console.WriteLine("\nFilter only completed tasks:");
            foreach (var task in Completed)
            {
                readToDo.PrintData(readToDo, task);
            }
        }




    }
}
