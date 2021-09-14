using Restaurant.Task1.Factory;
using System;
using TemplateMethod.Task1.Menu;

namespace AbstartFactory
{
    public class MasalaCooker
    {
        private ICooker cooker;

        public MasalaCooker(ICooker cooker)
        {
            this.cooker = cooker;
        }

        public void CookMasala(Country country)
        {
            IMenuFactory menuMaker = new BasicMenuFactory();

            menuMaker.CreateMenu(country).CookMasala(cooker);
        }
    }
}
