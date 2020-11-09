using System;

namespace Invisbar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Invisbar";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Select A Option For Your Taskbar:\n");
            Console.WriteLine("1. Completely Invisible");
            Console.WriteLine("2. Slightly Visible");
            Console.WriteLine("3. Default Taskbar\n");
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

            Explorer_Fix.restart();
            Console.WriteLine("Finished!\nPress Enter To Close This Window");
            Console.ReadLine();
        }
    }
}
