using System;
using System.Threading;

namespace Invisbar
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.SetWindowSize(42, 20);
                Console.Title = "Invisbar | github.com/Africanized";
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Visibility Options:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Completely Invisible");
                Console.WriteLine("2. Slightly Visible");
                Console.WriteLine("3. Default Taskbar Visibility");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Other Options:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("4. Reset All To Defaults");
                Console.WriteLine("0. Exit This Application");
                Console.WriteLine("------------------------------");
                Console.Write("Select An Option: ");
                int userInput = int.Parse(Console.ReadLine());

                //Change to "Completely Invisible".
                if (userInput == 1)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "1");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "0");
                }
                //Change to "Slightly Invisible".
                else if (userInput == 2)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "1");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "999");
                }
                //Change the taskbar back to default.
                else if (userInput == 3)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "0");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "999");
                }
                //Disable Everything.
                else if (userInput == 4)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "0");
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "999");
                }
                //Exiting the program.
                else if (userInput == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Response, Continuing....");
                    Thread.Sleep(2000);
                }
                //Restart explorer to apply changes.
                Explorer_Fix.restart();
                //Clear console to restart.
                Console.Clear();
            }
        }
    }
}
