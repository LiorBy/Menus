using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesDemonstration
    {
        private MainMenu m_MainMenu = new MainMenu(Constants.k_DelegatesHeadLine);
        private readonly SystemMethods r_CallMethod = new SystemMethods();

        public void StartDemonstration()
        {
            createDelegatesMenu(m_MainMenu);
            m_MainMenu.Show();
        }

        private void createDelegatesMenu(MainMenu i_MainMenu)
        {
            InternalMenu dateAndTimeMenu = new InternalMenu(Constants.k_DateAndTimeTitle, i_MainMenu);
            InternalMenu versionAndCapitalMenu = new InternalMenu(Constants.k_VersionAndCapitalsTitle, i_MainMenu);
            i_MainMenu.InsideOptionsList.Add(dateAndTimeMenu);
            i_MainMenu.InsideOptionsList.Add(versionAndCapitalMenu);
            ActiveMenuItem timeApp = new ActiveMenuItem(Constants.k_ShowTimeTitle, dateAndTimeMenu);
            timeApp.Choice += r_CallMethod.showCurrentTime; ////add pointer to the fuction to the event
            ActiveMenuItem dateApp = new ActiveMenuItem(Constants.k_ShowDateTitle, dateAndTimeMenu);
            dateApp.Choice += r_CallMethod.showTodayDate; ////add pointer to the fuction to the event

            dateAndTimeMenu.InsideOptionsList.Add(timeApp);
            dateAndTimeMenu.InsideOptionsList.Add(dateApp);
            ActiveMenuItem countCapitals = new ActiveMenuItem(Constants.k_CountCapitalsTitle, versionAndCapitalMenu);
            countCapitals.Choice += r_CallMethod.countCapitalLetterInSentence; ////add pointer to the fuction to the event
            ActiveMenuItem version = new ActiveMenuItem(Constants.k_ShowVersion, versionAndCapitalMenu);
            version.Choice += r_CallMethod.showVersion; ////add pointer to the fuction to the event
            versionAndCapitalMenu.InsideOptionsList.Add(countCapitals);
            versionAndCapitalMenu.InsideOptionsList.Add(version);         
        }
        
    }
}
