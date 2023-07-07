namespace UralskBot.Elements
{
    public class TextBoxElement : BaseElement
    {
        public TextBoxElement(By locator) : base(locator)
        {
        }

        public TextBoxElement(IWebElement element) : base(element)
        {
        }

        public void SendKeys(string text)
        {
            GetElement().SendKeys(text);
        }
    }
}