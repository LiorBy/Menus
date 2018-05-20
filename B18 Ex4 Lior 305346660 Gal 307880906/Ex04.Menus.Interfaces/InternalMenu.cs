using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
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
            ManegeUserOptions();
        }

        public override void BackToLastMenu()
        { //// Back to The Last Page
            GoToParentItem.SpecificChoice(); 
        }

        public List<MenuItem> InsideOptionsList
        {
            get { return r_InsideOptionsList; }
        }

        private void printInternalMenuToConsole()
        {
            r_DisplayMenuWindowObj.DisplayCurrentMenuWindow(Name, r_InsideOptionsList);
        }

        public void ManegeUserOptions()
        {
            printInternalMenuToConsole();
            int userChoise = verifyUserInput();
            if (userChoise != 0)
            {
                r_InsideOptionsList[userChoise - 1].SpecificChoice();   
            }
            else 
            {
                Console.Clear();
                BackToLastMenu();
            }        
        }

        private int verifyUserInput()
        {
            int userChoise = GetAnInputFromUser();
            while (!(userChoise >= 0 && userChoise <= r_InsideOptionsList.Capacity))
            {
                Console.SetCursorPosition(0, 8);
                Console.Beep();
                Console.Write(Constants.k_WorngInputMessage);
                userChoise = GetAnInputFromUser();
                Console.SetCursorPosition(0, 8);
                Console.Write("                                                     ");             
            }

            return userChoise;
        }
    }
}
