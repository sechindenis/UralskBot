namespace UralskBot.Elements
{
    public class ButtonElement : BaseElement
    {
        public ButtonElement(By locator) : base(locator)
        {
        }

        public ButtonElement(IWebElement element) : base(element)
        {
        }

        public void Click()
        {
            GetElement().Click();
        }

        public string GetLink()
        {
            return GetElement().GetAttribute("href");
        }
    }
}