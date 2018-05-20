using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateDisplayer : IAbilityToOperate
    {
        public void ExecutActionMethod()
        {
            showTodayDate();
        }

        private void showTodayDate()
        {
            Console.Clear();
            char endDisplay;
            Console.WriteLine("The Date Is: ");
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
            Console.Clear();
        }
    }
}
