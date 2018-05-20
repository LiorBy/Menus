﻿using System;
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
            bool endLoopDisplay = false;
            Console.Clear();
            Console.SetCursorPosition(Constants.k_DisplayTimeLine, Constants.k_DisplayTimeColumn);
            Console.WriteLine("The Time Is : ");
            Console.SetCursorPosition(Constants.k_DisplayTimeLine + 3, Constants.k_DisplayTimeColumn);
            Console.WriteLine("Press any key to end display");
            while (!endLoopDisplay)
            {
                while (Console.KeyAvailable)
                {
                    endDisplay = Console.ReadKey().KeyChar;
                    endLoopDisplay = true;
                }
                Console.SetCursorPosition(Constants.k_DisplayTimeLine + 1, Constants.k_DisplayTimeColumn);
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            }
            
            Console.Clear();
        }
    }
}