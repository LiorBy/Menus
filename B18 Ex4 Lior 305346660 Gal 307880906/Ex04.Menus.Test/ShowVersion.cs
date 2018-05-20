using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IAbilityToOperate
    {
        public void ExecutActionMethod()
        {
            showVersion();
        }

        private void showVersion()
        {
            Console.Clear();
            char endDisplay;
            Console.WriteLine("Version: 18.2.4.0");
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
            Console.Clear();
        }
    }
}
