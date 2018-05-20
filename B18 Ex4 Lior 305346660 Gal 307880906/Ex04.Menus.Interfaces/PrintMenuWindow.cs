using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class PrintMenuWindow
    {
        
        public void DisplayCurrentMenuWindow(string i_HeadLineOfTheWindow, List<MenuItem> i_InsideWindowOptionsList)
        {
            Console.WriteLine(Constants.k_OneLine);
            int counter = 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(i_HeadLineOfTheWindow);
            PrintBackLineForHeadLine(i_HeadLineOfTheWindow.Length);
            Console.ResetColor();
            foreach (MenuItem item in i_InsideWindowOptionsList)
            {
                Console.Write("{0},{1}.,{2} ", Constants.k_WindowBoarder, counter, item.Name);
                Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber,counter + 2 );
                Console.WriteLine(Constants.k_WindowBoarder);
                counter++;
            }
            Console.WriteLine(Constants.k_OneLine);
        }

        private void PrintBackLineForHeadLine(int i_NumberOfCharsInTheHeadLine)
        {
            for(int i = 0; i < i_NumberOfCharsInTheHeadLine;i ++)
            {
                Console.WriteLine(Constants.k_BackLineChar);
            }
            Console.WriteLine();
        }
    }
}
