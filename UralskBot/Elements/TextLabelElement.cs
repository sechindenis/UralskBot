namespace UralskBot.Elements
{
    public class TextLabelElement : BaseElement
    {
        public TextLabelElement(By locator) : base(locator)
        {
        }

        public TextLabelElement(IWebElement element) : base(element)
        {            
        }

        public string GetText()
        {
            return GetElement().Text;
        }
    }
}