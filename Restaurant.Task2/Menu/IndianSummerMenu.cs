using AbstartFactory;

namespace TemplateMethod.Task1.Menu
{
    public class IndianSummerMenu : RestourantMenu
    {
        protected override void CookRice(ICooker cooker)
        {
            cooker.FryRice(100, Level.Low);
            cooker.PepperRice(Level.Medium);
        }

        protected override void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(100, Level.Low);
            cooker.PepperChicken(Level.Medium);
        }
    }
}
