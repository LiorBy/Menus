using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class ShowVersion
    {
        class CapitalLettersCounter : IAbilityToOperate
        {
            public void ExecutActionMethod()
            {
                showVersion();
            }

            private void showVersion()
            {
                char endDisplay;
                Console.WriteLine("Version: 18.2.4.0");
                Console.Clear();
                Console.WriteLine("Press any key to end display...");
                endDisplay = Console.ReadKey().KeyChar;
            }
        }
    }
}
