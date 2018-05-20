using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class ActiveMenuItem : MenuItem
    {
        private readonly IAbilityToOperate r_ChosenOption;

        public ActiveMenuItem(string i_ActiveMenuItemName, MenuItem i_ActiveMenuItemParent, IAbilityToOperate i_ChosenOption)
            :base(i_ActiveMenuItemName, i_ActiveMenuItemParent)
        {
            r_ChosenOption = i_ChosenOption;
        }
        public override void SpecificChoice()
        {
            ActiveTheMethod();
        }

        public override void BackToLastMenu()
        {
            
        }
        private void ActiveTheMethod()
        {
            r_ChosenOption.ExecutActionMethod();


        }
    }
}
