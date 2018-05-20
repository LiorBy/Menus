using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActiveMenuItem : MenuItem
    {
        private readonly IAbilityToOperate r_ChosenOption;

        public ActiveMenuItem(string i_ActiveMenuItemName, MenuItem i_ActiveMenuItemParent, IAbilityToOperate i_ChosenOption)
            :base(i_ActiveMenuItemName, i_ActiveMenuItemParent)
        {
            r_ChosenOption = i_ChosenOption;
        }
        public override void SpecificChoice()
        {
            activeTheMethod();
        }

        public override void BackToLastMenu()
        {
            this.GoToParentItem.SpecificChoice();
        }

        private void activeTheMethod()
        {
            r_ChosenOption.ExecutActionMethod();
            //int userInputAsInt = GetAnInputFromUser();
            //while(userInputAsInt != 0 )
            //{
            //    Console.Beep();
            //    Console.WriteLine(Constants.k_WorngInputMessage);
            //    userInputAsInt = GetAnInputFromUser();
            //}
            Console.Clear();
            BackToLastMenu();

        }
    }
}
