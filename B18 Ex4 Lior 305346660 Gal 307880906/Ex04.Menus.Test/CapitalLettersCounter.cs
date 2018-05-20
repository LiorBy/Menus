using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class CapitalLettersCounter : IAbilityToOperate
    {
        public void ExecutActionMethod()
        {
            countCapitalLetterInSentence();
        }

        private void countCapitalLetterInSentence()
        {
            Console.Clear();
            char endDisplay;
            string userSenteneInput;
            int capitalLettersCounter = 0;
            Console.WriteLine("Please enter a sentence : ");
            userSenteneInput = Console.ReadLine();
            for (int i = 0; i < userSenteneInput.Length; i++)
            {
                if (char.IsUpper(userSenteneInput[i]))
                {
                    capitalLettersCounter++;
                }
            }

            Console.Clear();
            Console.WriteLine("There are {0} Capital letters in the sentence - ", capitalLettersCounter);
            Console.WriteLine(userSenteneInput);
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
        }
    }
}
