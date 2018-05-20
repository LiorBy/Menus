using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_NameItem;
        private MenuItem m_ParentItem;

        public MenuItem(string i_NameItem, MenuItem i_ParentItem)
        {
            r_NameItem = i_NameItem;
            m_ParentItem = i_ParentItem;
        }

        public abstract void  X(); //// abstract methods when we click on this menu item

        public string Name
        {
            get { return r_NameItem; }
        }

        //public MenuItem GoToParentItem
        //{
        //    get { return m_ParentItem; }
        //}

        //public MenuItem SetParentItem
        //{
        //    set { m_ParentItem = value; }
        //}



    }
}
