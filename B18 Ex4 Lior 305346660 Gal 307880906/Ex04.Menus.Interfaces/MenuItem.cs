using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private readonly string r_NameItem;
        private MenuItem m_ParentItem;

        public MenuItem(string i_NameItem, MenuItem i_ParentItem)
        {
            r_NameItem = i_NameItem;
            m_ParentItem = i_ParentItem;
        }

        public virtual void SpecificChoice()
        {
        } 

        public virtual void BackToLastMenu()
        {
        }

        public string Name
        {
            get { return r_NameItem; }
        }

        public MenuItem GoToParentItem
        {
            get { return m_ParentItem; }
        }

        public MenuItem SetParentItem
        {
            set { m_ParentItem = value; }
        }

        public int GetAnInputFromUser()
        {
            char userInput = Console.ReadKey().KeyChar;
            int userInputAsInt;
            if (!int.TryParse(char.ToString(userInput), out userInputAsInt))
            {
                throw new FormatException(Constants.k_WorngFormatInputMessage);
            }

            return userInputAsInt;
        }
    }
}
