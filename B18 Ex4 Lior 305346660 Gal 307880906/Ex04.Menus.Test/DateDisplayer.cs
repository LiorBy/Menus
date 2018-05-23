using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateDisplayer : IAbilityToOperate
    {
        private readonly SystemMethods r_CallMethod = new SystemMethods();

        public void ExecutActionMethod()
        {
            r_CallMethod.showTodayDate();
        }

    }
}
