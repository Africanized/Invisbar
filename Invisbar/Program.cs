using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Invisbar
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Title = "Invisbar";
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Visibility Options:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Completely Invisible");
                Console.WriteLine("2. Slightly Visible");
                Console.WriteLine("3. Default Taskbar Visibility");
                Console.WriteLine("------------------------------");
                Console.WriteLine("\nMinor Tweaks:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("4. Show Seconds On Clock");
                Console.WriteLine("5. Reset All To Defaults");
                Console.WriteLine("------------------------------");
                Console.WriteLine("\nOther Options:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("6. Exit This Application");
                Console.WriteLine("------------------------------");
                Console.Write("Choose A Option For Your Taskbar: ");
                int userInput = int.Parse(Console.ReadLine());

                Console.Clear();

                if (userInput == 1)
                {
                    //completly invisible
                    Console.WriteLine("Editing Taskbar...\n");
                    //set transparency effects on
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "1");
                    //set invisible taskbar on
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "0");
                }
                else if (userInput == 2)
                {
                    //slightly invisible
                    Console.WriteLine("Editing Taskbar...\n");
                    //transparency effects on
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "1");
                    //invisible taskbar off
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "999");
                    //restart explorer
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    //transparency effects off
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "0");
                    //invisible taskbar off
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "999");
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    //add seconds regkey
                    Explorer_Fix.regkey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", "1");
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("Editing Taskbar...\n");
                    //transparency effects off
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "0");
                    //invisible taskbar off
                    Explorer_Fix.regkey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAcrylicOpacity", "999");
                    //disable seconds on clock
                    Explorer_Fix.regkey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock", "0");
                }
                else if (userInput == 6)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Unexpected Response, Continuing....");
                    Thread.Sleep(2000);
                }
                Explorer_Fix.restart();
                Console.Clear();
            }
            

            
        }
    }
}
