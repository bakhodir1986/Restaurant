using Restaurant.Task1.Factory;
using System;

namespace AbstartFactory
{
    public class MasalaCooker
    {
        private ICooker cooker;

        public MasalaCooker(ICooker cooker)
        {
            this.cooker = cooker;
        }

        public void CookMasala(DateTime currentDate, Country country)
        {
            IMenuFactory menuMaker;

            if (IsSummerDate(currentDate))
            {
                menuMaker = new SummerMenuFactory();
            }
            else
            {
                menuMaker = new BasicMenuFactory();
            }

            menuMaker.CreateMenu(country).CookMasala(cooker);
        }

        private bool IsSummerDate(DateTime currentDate)
        {
            return currentDate.Month >= 6 && currentDate.Month <= 8;
        }
    }
}
