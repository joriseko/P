using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P
{
    class ReadToDo
    {
        private string status;
        public string Name { get; set; }
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
            Name = lineData[0];
            Status = lineData[1];
            Console.WriteLine($"Task: {Name}, Status:[{Status}]");
        }


        public void SortCompleted(string task)
        {
            string[] lineData = task.Split(',');
            Name = lineData[0];
            Status = lineData[1];
            if (lineData[1]=="1")
            {
             Console.WriteLine($"Task: {Name}, Status:[{Status}]");
            }
        }

        public void SortNotCompleted(string task)
        {
            string[] lineData = task.Split(',');
            Name = lineData[0];
            Status = lineData[1];
            if (lineData[1] == "0")
            {
                Console.WriteLine($"Task: {Name}, Status:[{Status}]");
            }
        }

        public void SortUnknown(string task)
        {
            string[] lineData = task.Split(',');
            Name = lineData[0];
            Status = lineData[1];
            if (lineData[1] == "2")
            {
                Console.WriteLine($"Task: {Name}, Status:[{Status}]");
            }
        }

        public void DeleteCompleted(string task)
        {
            string[] lineData = task.Split(',');
            Name = lineData[0];
            Status = lineData[1];
            if (lineData[1] != "1")
            {
                File.AppendAllText("ToDoWithoutCompleted.txt", Name + ','+lineData[1]+ Environment.NewLine);  
            }     
        }




    }
}