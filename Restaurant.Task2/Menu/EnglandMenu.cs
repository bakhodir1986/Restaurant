using AbstartFactory;

namespace TemplateMethod.Task1.Menu
{
    public class EnglandMenu : RestourantMenu
    {
        protected override void CookRice(ICooker cooker)
        {
            cooker.FryRice(100, Level.Low);
        }

        protected override void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(100, Level.Low);
        }
    }
}
