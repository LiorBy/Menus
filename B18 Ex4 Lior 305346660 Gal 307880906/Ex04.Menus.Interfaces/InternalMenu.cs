﻿using System;
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
            manegeUserOptions();
        }
        public override void BackToLastMenu()
        {
            this.GoToParentItem.SpecificChoice(); //Back to The Last Page
        }
        public List<MenuItem> InsideOptionsList
        {
            get { return r_InsideOptionsList; }
        }

        private void printInternalMenuToConsole()
        {
            r_DisplayMenuWindowObj.DisplayCurrentMenuWindow(Name, r_InsideOptionsList);
        }

        public void manegeUserOptions()
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
                this.BackToLastMenu();
            }
          
        }

        private int verifyUserInput()
        {
            int userChoise = GetAnInputFromUser();
            while (userChoise < 0 || userChoise > r_InsideOptionsList.Capacity)
            {
                Console.Beep();
                Console.Write(Constants.k_WorngInputMessage);
                userChoise = GetAnInputFromUser();
            }

            return userChoise;

        }
        ///private void printInternalMenu

    }
}
