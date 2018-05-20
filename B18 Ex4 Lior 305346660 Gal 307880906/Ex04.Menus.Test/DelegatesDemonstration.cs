using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;
namespace Ex04.Menus.Test
{
    public class DelegatesDemonstration
    {
        private MainMenu m_MainMenu = new MainMenu(Constants.k_DelegatesHeadLine);

        public void StartDemonstration()
        {
            createInterfaceMenu(m_MainMenu);
            m_MainMenu.Show();
        }

        private void createInterfaceMenu(MainMenu i_MainMenu)
        {
            InternalMenu dateAndTimeMenu = new InternalMenu(Constants.k_DateAndTimeTitle, i_MainMenu);
            InternalMenu versionAndCapitalMenu = new InternalMenu(Constants.k_VersionAndCapitalsTitle, i_MainMenu);

            i_MainMenu.InsideOptionsList.Add(dateAndTimeMenu);
            i_MainMenu.InsideOptionsList.Add(versionAndCapitalMenu);

            ActiveMenuItem timeApp = new ActiveMenuItem(Constants.k_ShowTimeTitle, dateAndTimeMenu);
            timeApp.Choice += this.showCurrentTime;////add pointer to the fuction to the event
            ActiveMenuItem dateApp = new ActiveMenuItem(Constants.k_ShowDateTitle, dateAndTimeMenu);
            dateApp.Choice += this.showTodayDate;////add pointer to the fuction to the event

            dateAndTimeMenu.InsideOptionsList.Add(timeApp);
            dateAndTimeMenu.InsideOptionsList.Add(dateApp);

            ActiveMenuItem countCapitals = new ActiveMenuItem(Constants.k_CountCapitalsTitle, versionAndCapitalMenu);
            countCapitals.Choice += this.countCapitalLetterInSentence;////add pointer to the fuction to the event
            ActiveMenuItem version = new ActiveMenuItem(Constants.k_ShowVersion, versionAndCapitalMenu);
            version.Choice += this.showVersion;////add pointer to the fuction to the event

            versionAndCapitalMenu.InsideOptionsList.Add(countCapitals);
            versionAndCapitalMenu.InsideOptionsList.Add(version);

            
        }


        ////------Implementation of all the methods--------
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

        private void showVersion()
        {
            Console.Clear();
            char endDisplay;
            Console.WriteLine("Version: 18.2.4.0");
            Console.WriteLine("Press any key to end display...");
            endDisplay = Console.ReadKey().KeyChar;
            Console.Clear();
        }

        private void showCurrentTime()
        {
            char endDisplay;
            bool endLoopDisplay = false;
            Console.Clear();
            Console.SetCursorPosition(Constants.k_DisplayTimeColumn, Constants.k_DisplayTimeLine);
            Console.WriteLine("The Time Is : ");
            Console.SetCursorPosition(Constants.k_DisplayTimeColumn, Constants.k_DisplayTimeLine + 3);
            Console.WriteLine("Press any key to end display");
            while (!endLoopDisplay)
            {
                while (Console.KeyAvailable)
                {
                    endDisplay = Console.ReadKey().KeyChar;
                    endLoopDisplay = true;
                }

                Console.SetCursorPosition(Constants.k_DisplayTimeColumn, Constants.k_DisplayTimeLine + 1);
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            }

            Console.Clear();
        }

        ////----------------------------------------------------------------------------------------------------




    }
}
