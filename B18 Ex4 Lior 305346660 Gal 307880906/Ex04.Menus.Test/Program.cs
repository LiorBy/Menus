using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;
            InterfaceDemonstration test1 = new InterfaceDemonstration();
            test1.StartDemonstration();
        }
    }
}
