﻿using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceDemonstration
    {
        private MainMenu m_MainMenu = new MainMenu(Constants.k_InterfaceHeadLine);

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

            ActiveMenuItem timeApp = new ActiveMenuItem(Constants.k_ShowTimeTitle, dateAndTimeMenu, new TimeDisplayer());
            ActiveMenuItem dateApp = new ActiveMenuItem(Constants.k_ShowDateTitle, dateAndTimeMenu, new DateDisplayer());

            dateAndTimeMenu.InsideOptionsList.Add(timeApp);
            dateAndTimeMenu.InsideOptionsList.Add(dateApp);

            ActiveMenuItem countCapitals = new ActiveMenuItem(Constants.k_CountCapitalsTitle, versionAndCapitalMenu, new CapitalLettersCounter());
            ActiveMenuItem version = new ActiveMenuItem(Constants.k_ShowVersion, versionAndCapitalMenu, new ShowVersion());

            versionAndCapitalMenu.InsideOptionsList.Add(countCapitals);
            versionAndCapitalMenu.InsideOptionsList.Add(version);
        }
    }
}