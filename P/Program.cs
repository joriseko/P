using System;
using System.IO;

namespace P
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintToDo printToDo = new PrintToDo();
            printToDo.Print();
            Console.WriteLine();

            Controller controller = new Controller();
            controller.StartToDoConsole();



        }
    }
}
