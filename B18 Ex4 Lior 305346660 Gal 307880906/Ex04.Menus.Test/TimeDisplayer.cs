using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TimeDisplayer : IAbilityToOperate
    {     
        public void ExecutActionMethod()
        {
            showCurrentTime();
        }

        private void showCurrentTime()
        {
            char endDisplay;
            Console.WriteLine("The Time Is : ");
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("Press any key to end display");
            endDisplay = Console.ReadKey().KeyChar;
            Console.Clear();
        }
    }
}
