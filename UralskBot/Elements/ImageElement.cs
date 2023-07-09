namespace UralskBot.Elements
{
    public class ImageElement : BaseElement
    {
        public ImageElement(By locator) : base(locator)
        {
        }

        public ImageElement (IWebElement element) : base(element)
        {
        }

        public string GetSrc()
        {
            return GetElement().GetAttribute("src");
        }
    }
}