using AbstartFactory;

namespace TemplateMethod.Task1.Menu
{
    public class EnglandSummerMenu : RestourantMenu
    {
        protected override void CookRice(ICooker cooker)
        {
            cooker.FryRice(50, Level.Low);
        }

        protected override void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(50, Level.Low);
        }
    }
}
