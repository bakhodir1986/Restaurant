using AbstartFactory;

namespace TemplateMethod.Task1.Menu
{
    public class UkraineSummerMenu : RestourantMenu
    {
        protected override void CookRice(ICooker cooker)
        {
            cooker.FryRice(150, Level.Medium);
            cooker.SaltRice(Level.Low);
        }

        protected override void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(200, Level.Medium);
            cooker.SaltChicken(Level.Low);
        }

    }
}
