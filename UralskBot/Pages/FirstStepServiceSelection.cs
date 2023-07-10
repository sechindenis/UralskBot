using UralskBot.Elements;

namespace UralskBot.Pages
{
    public class FirstStepServiceSelection
    {
        public const string foreignPassportTenYearsButtonElementXPath = "//*[contains(text(), 'сроком на 10 лет')]";

        public ButtonElement _servicesProviderSelectElement;
        public TextLabelElement _settingBlockTextLabelElement;

        public FirstStepServiceSelection()
        {
            _servicesProviderSelectElement = new ButtonElement(By.XPath($"{ foreignPassportTenYearsButtonElementXPath }"));
        }

        public void ClickForeignPassportTenYearsButton()
        {
            ScrollToForeignPassportTenYearsButton();
            _servicesProviderSelectElement.Click();
        }

        public void ScrollToForeignPassportTenYearsButton()
        {
            new Actions(Browser.GetDriver())
                .ScrollByAmount(0, 1000)
                .Perform();
        }
    }
}