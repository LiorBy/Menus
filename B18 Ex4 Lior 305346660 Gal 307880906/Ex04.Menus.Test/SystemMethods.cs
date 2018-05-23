using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
     public class SystemMethods
    {
        public void countCapitalLetterInSentence()
        {
            Console.Clear();
            char endDisplay;
            string userSenteneInput;
            int capitalLettersCounter = 0;
            Console.WriteLine("Please enter a sentence : ");
            userSenteneInput = Console.ReadLine();
            for (int i = 0; i < userSenteneInput.Length; i++)
            {
                if (char.IsUpper(userSenteneInput[i]))
                {
                    capitalLettersCounter++;
                }
            }

            Console.Clear();
            Console.WriteLine("There are {0} Capital letters in the sentence - ", capitalLettersCounter);
            Console.WriteLine(userSenteneInput);
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
        }

        public void showTodayDate()
        {
            Console.Clear();
            char endDisplay;
            Console.WriteLine("The Date Is: ");
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
            Console.Clear();
        }

        public void showVersion()
        {
            Console.Clear();
            char endDisplay;
            Console.WriteLine("Version: 18.2.4.0");
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
            Console.Clear();
        }

        public void showCurrentTime()
        {
            char endDisplay;
            bool endLoopDisplay = false;
            Console.Clear();
            Console.SetCursorPosition(Constants.k_DisplayTimeColumn, Constants.k_DisplayTimeLine);
            Console.WriteLine("The Time Is : ");
            Console.SetCursorPosition(Constants.k_DisplayTimeColumn, Constants.k_DisplayTimeLine + 2);
            Console.WriteLine("Press any key to end display");
            while (!endLoopDisplay)
            {
                while (Console.KeyAvailable)
                {
                    endDisplay = Console.ReadKey().KeyChar;
                    endLoopDisplay = true;
                }

                Console.SetCursorPosition(Constants.k_DisplayTimeColumn, Constants.k_DisplayTimeLine + 1);
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            }

            Console.Clear();
        }
    }
}