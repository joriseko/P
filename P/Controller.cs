using System;
using System.Collections.Generic;
using System.Text;

namespace P
{
    class Controller
    {

        public void StartToDoConsole()
        {
            
            bool needToRender = true;


            Console.WriteLine($"Choose:\n Enter - show all to do list\n C - show completed list\n N - show not completed list\n U - show unknown list\n D - runs all tasks/creates new file excl. completed/opens it\n + - add task\n M - runs all tasks/asks status change/creates new file\n Esc - finish work ");
            do
            {

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();
                    PrintToDo printToDo = new PrintToDo();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.Clear();
                            printToDo.Print();
                            Console.WriteLine();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.M:
                            Console.Clear();
                            printToDo.PrintAllChangingStatus();
                            Console.WriteLine();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.OemPlus:
                            Console.Clear();
                            WriteToDo writeToDo = new WriteToDo();
                            writeToDo.AddTask();
                            Console.Clear();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.C:
                            Console.Clear();
                            printToDo.PrintCompleted();
                            Console.WriteLine();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            printToDo.PrintNotCompleted();
                            Console.WriteLine();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.U:
                            Console.Clear();
                            printToDo.PrintUnknown();
                            Console.WriteLine();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.D:
                            Console.Clear();
                            printToDo.PrintToFileDeleteCompleted();
                            Console.WriteLine();
                            StartToDoConsole();
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            needToRender = false;
                            Environment.Exit(1);
                            break;
                    }
                }
            } while (needToRender);





        }
    }
}
