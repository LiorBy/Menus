using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ChoiceNotifyDelegate();

    public class ActiveMenuItem : MenuItem
    {
        public event ChoiceNotifyDelegate Choice;

        public ActiveMenuItem(string i_ActiveMenuItemName, MenuItem i_ActiveMenuItemParent)
            : base(i_ActiveMenuItemName, i_ActiveMenuItemParent)
        {
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
            
            Console.Clear();
            onChoice();
            BackToLastMenu();

        }

        private void onChoice()
        {
            ////Lets tell the parent about my chise in the menu and activate a Function
            if(Choice != null) 
            {
                Choice.Invoke();
            }

        }




    }
}
