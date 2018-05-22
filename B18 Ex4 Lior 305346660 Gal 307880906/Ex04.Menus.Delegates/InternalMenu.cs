using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class InternalMenu : MenuItem
    {
        private readonly List<MenuItem> r_InsideOptionsList = new List<MenuItem>();
        private readonly PrintMenuWindow r_DisplayMenuWindowObj = new PrintMenuWindow();

        public InternalMenu(string i_InternatMenuName, MenuItem i_InternalMenuParent)
            : base(i_InternatMenuName, i_InternalMenuParent)
        {
        }

        public override void SpecificChoice()
        {
            Console.Clear();
            Show();
        }

        public override void BackToLastMenu()
        {
            this.GoToParentItem.SpecificChoice(); ////Back to The Last Page
        }

        public List<MenuItem> InsideOptionsList
        {
            get { return r_InsideOptionsList; }
        }

        private void printInternalMenuToConsole()
        {
            r_DisplayMenuWindowObj.DisplayCurrentMenuWindow(Name, r_InsideOptionsList);
        }

        public void Show()
        {
            printInternalMenuToConsole();
            int userChoice = verifyUserInput();
            if (userChoice != 0)
            {
                r_InsideOptionsList[userChoice - 1].SpecificChoice();
            }
            else
            {
                Console.Clear();
                this.BackToLastMenu();
            }
        }

        private int verifyUserInput()
        {
            int userChoice = Constants.k_EmptyInput;
            bool inputIsCorrect = false;
            while (!inputIsCorrect)
            {
                try
                {
                    userChoice = GetAnInputFromUser();
                    if (!(userChoice >= 0 && userChoice <= r_InsideOptionsList.Count))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        inputIsCorrect = true;
                    }
                }
                catch (ArgumentOutOfRangeException rangeException)
                {
                    Console.Beep();
                    Console.SetCursorPosition(0, 8);
                    Console.WriteLine("                                                                     ");
                    Console.SetCursorPosition(0, 8);
                    Console.Write(rangeException.Message);
                }
                catch (FormatException onlyNumbersException)
                {
                    Console.Beep();
                    Console.SetCursorPosition(0, 8);
                    Console.WriteLine("                                                                     ");
                    Console.SetCursorPosition(0, 8);
                    Console.Write(onlyNumbersException.Message);
                }         
            }

            return userChoice;
        }
    }
}