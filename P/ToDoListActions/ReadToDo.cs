using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P
{
    class ReadToDo
    {
        private string status;
        public string Task { get; set; }
        public string Status
        {
            get { return status; }

            set
            {
                if (value == "0")
                {
                    status = "Not completed";
                }
                else if (value == "1")
                {
                    status = "Completed";
                }
                else
                {
                    status = "Unknown";
                }
            }
        }



        public void PrintAll(string task)
        {

            string[] lineData = task.Split(',');
            Task = lineData[0];
            Status = lineData[1];
            Console.WriteLine($"Task: {Task}, Status:[{Status}]");
        }


        public void SortCompleted(string task)
        {
            string[] lineData = task.Split(',');
            Task = lineData[0];
            Status = lineData[1];
            if (lineData[1] == "1")
            {
                Console.WriteLine($"Task: {Task}, Status:[{Status}]");
            }
        }

        public void SortNotCompleted(string task)
        {
            string[] lineData = task.Split(',');
            Task = lineData[0];
            Status = lineData[1];
            if (lineData[1] == "0")
            {
                Console.WriteLine($"Task: {Task}, Status:[{Status}]");
            }
        }

        public void SortUnknown(string task)
        {
            string[] lineData = task.Split(',');
            Task = lineData[0];
            Status = lineData[1];
            if (lineData[1] == "2")
            {
                Console.WriteLine($"Task: {Task}, Status:[{Status}]");
            }
        }

        public void DeleteCompleted(string task)
        {
            string[] lineData = task.Split(',');
            Task = lineData[0];
            Status = lineData[1];
            if (lineData[1] != "1")
            {
                File.AppendAllText("ToDoWithoutCompleted.txt", Task + ',' + lineData[1] + Environment.NewLine);
            }
        }

        public void RunThroughAllnChangeStatus(string task)
        {
            string[] lineData = task.Split(',');
            Task = lineData[0];
            Status = lineData[1];
            Console.WriteLine($"Task: {Task}, Status:[{Status}]");
            Console.WriteLine();
            Console.WriteLine("Do you want to change task status?");
            Console.Write("0 - Not Completed, 1 - Completed, 2 - Unknown, any key - leave as is: ");
            string newStatus = Convert.ToString(Console.ReadLine());
            if (newStatus != "0" && newStatus != "1" && newStatus != "2")
            {
                File.AppendAllText("ToDoListChangeState.txt", Task + ',' + Status + Environment.NewLine);
            }
            else
            {
                Status = newStatus;
                File.AppendAllText("ToDoListChangeState.txt", Task + ',' + Status + Environment.NewLine);
            }
            Console.Clear();
        }





        /*         
                    string[] filePaths = Directory.GetFiles(@"C:\Users\joriseko\source\repos\P\P\bin\Debug\netcoreapp3.1\", "*.txt");
                    Console.WriteLine("--- Files: ---");
                    foreach (string name in filePaths)
                    {
                        Console.WriteLine(name);
                    }

        string[] lineData = task.Split(',');
        Status = lineData[0];
        lineData[1]= "xxx";
        File.("ToDoList.txt", lineData[0] + Status + Environment.NewLine);
        Console.ReadKey();


        File.AppendAllText("ToDoList.txt", Task + ',' + Status + Environment.NewLine);
        Console.WriteLine($"Task: {Task}, Status:[{Status}]");

        Status = newStatus;
        */
    }
}