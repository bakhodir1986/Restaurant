using AbstartFactory;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Menu;

namespace Restaurant.Task1.Factory
{
    public class MenuFactory
    {
        private Country country;

        public MenuFactory(Country country)
        {
            this.country = country;
        }

        public RestourantMenu CreateMenu()
        {
            if (country == Country.India)
                return new IndianMenu();
            else if (country == Country.Ukraine)
                return new UkraineMenu();
            else
                return new EnglandMenu();
        }

    }
}
