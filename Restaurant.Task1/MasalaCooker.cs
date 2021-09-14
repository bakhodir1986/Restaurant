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
            IMenuMaker menuMaker;

            if (country == Country.India)
            {
                menuMaker = new IndianMenuMaker();
            }
            else if (country == Country.Ukraine)
            {
                menuMaker = new UkraineMenuMaker();
            }
            else if (country == Country.England)
            {
                menuMaker = new EnglandMenuMaker();
            }
            else
            {
                throw new ApplicationException("Invalid country");
            }

            menuMaker.CreateMenu().CookMasala(cooker);
        }
    }
}
