using AbstartFactory;

namespace TemplateMethod.Task1.Menu
{
    public class IndianMenu : RestourantMenu
    {
        protected override void CookRice(ICooker cooker)
        {
            cooker.FryRice(200, Level.Strong);
            cooker.SaltRice(Level.Strong);
            cooker.PepperRice(Level.Strong);
        }

        protected override void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(100, Level.Strong);
            cooker.SaltChicken(Level.Strong);
            cooker.PepperChicken(Level.Strong);
        }
    }
}
