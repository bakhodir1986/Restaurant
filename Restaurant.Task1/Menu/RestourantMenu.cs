using AbstartFactory;

namespace TemplateMethod.Task1.Menu
{
    public abstract class RestourantMenu
    {
        public void CookMasala(ICooker cooker)
        {
            CookRice(cooker);
            CookChicken(cooker);
        }

        protected abstract void CookRice(ICooker cooker);
        protected abstract void CookChicken(ICooker cooker);
    }
}
