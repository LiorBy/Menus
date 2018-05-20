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
            int counterLine = 3;
            printHeadLine(i_HeadLineOfTheWindow);
            foreach (MenuItem item in i_InsideWindowOptionsList)
            {
                Console.Write("{0},{1}.,{2} ", Constants.k_WindowBoarder, counterLine - 2, item.Name);
                Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber,counterLine);
                Console.WriteLine(Constants.k_WindowBoarder);
                counterLine++;
            }

            Console.Write("{0},{1} ", Constants.k_WindowBoarder, Constants.k_BackToTheLastMenuMessage);
            Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber, counterLine);
            Console.WriteLine(Constants.k_WindowBoarder);
            counterLine++;
            Console.Write("{0},{1},({2} - {3}) : ", Constants.k_WindowBoarder,Constants.k_ChoseAnOptionMessage, Constants.k_FirstOptionNumber , counterLine - 2) ;
            Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber, counterLine);
            Console.WriteLine(Constants.k_WindowBoarder);
            Console.WriteLine(Constants.k_OneLine);
        }
        
        private void printHeadLine(string i_HeadLineName)
        {
            int counterLine = 0;
            Console.Write(Constants.k_WindowBoarder);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
            Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber, counterLine +1);
            Console.WriteLine(Constants.k_WindowBoarder);
            Console.Write(Constants.k_WindowBoarder);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i_HeadLineName);
            Console.ResetColor();
            Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber, counterLine + 2);
            Console.WriteLine(Constants.k_WindowBoarder);
            Console.Write(Constants.k_WindowBoarder);
            printBackLineForHeadLine(i_HeadLineName.Length);
            Console.SetCursorPosition(Constants.k_RightWindowEdgeNumber, counterLine + 3);
            Console.WriteLine(Constants.k_WindowBoarder);
        }

        private void printBackLineForHeadLine(int i_NumberOfCharsInTheHeadLine)
        {
            for(int i = 0; i < i_NumberOfCharsInTheHeadLine;i ++)
            {
                Console.WriteLine(Constants.k_BackLineChar);
            }
            Console.WriteLine();
        }
    }
}
