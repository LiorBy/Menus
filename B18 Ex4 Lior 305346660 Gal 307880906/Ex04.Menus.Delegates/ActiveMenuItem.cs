using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ChoiceNotifyDelegate();

    class ActiveMenuItem : MenuItem
    {
        public event ChoiceNotifyDelegate Choice;

        public ActiveMenuItem(string i_ActiveMenuItemName, MenuItem i_ActiveMenuItemParent)
            : base(i_ActiveMenuItemName, i_ActiveMenuItemParent)
        {
        }

        public override void SpecificChoise()
        {
            activeTheMethod();
        }

        public override void BackToLastMenu()
        {
            this.GoToParentItem.SpecificChoise();
        }

        private void activeTheMethod()
        {
            
            Console.Clear();
            onChoise();
            BackToLastMenu();

        }

        private void onChoise()
        {
            ////Lets tell the parent about my chise in the menu and activate a Function
            if(Choice != null) 
            {
                Choice.Invoke();
            }

        }




    }
}
