using UralskBot.Elements;

namespace UralskBot.Pages
{
    public class SecondStepDateSelection
    {
        public const string dateButtonElementXPath = "//*[contains(@class, 'DateBox')]/*[contains(text(), '/')]]";

        public ButtonElement _dateButtonElement;

        public SecondStepDateSelection()
        {
            _dateButtonElement = new ButtonElement(By.XPath($"{dateButtonElementXPath}"));
        }

        public void ClickDateButton()
        {
            _dateButtonElement.Click();
        }


    }
}