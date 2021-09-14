using AbstartFactory;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Menu;

namespace Restaurant.Task1.Factory
{
    public class BasicMenuFactory : IMenuFactory
    {
        public RestourantMenu CreateMenu(Country country)
        {
            RestourantMenu menu;

            if (country == Country.India)
            {
                menu = new IndianMenu();
            }
            else if (country == Country.Ukraine)
            {
                menu = new UkraineMenu();
            }
            else if (country == Country.England)
            {
                menu = new EnglandMenu();
            }
            else
            {
                throw new ApplicationException("Invalid country");
            }

            return menu;
        }
    }
}
