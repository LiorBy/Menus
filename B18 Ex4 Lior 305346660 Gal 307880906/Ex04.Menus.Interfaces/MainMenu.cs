using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu :InternalMenu
    {
        public MainMenu(string i_MainMenuName) : base (i_MainMenuName, null)
        {
        }

        public override void BackToLastMenu() //Finish run Interface Menu
        {
            Console.Clear();
        }



    }
}
