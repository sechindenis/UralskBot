using UralskBot.Elements;

namespace UralskBot.Forms
{
    public abstract class BaseForm
    {
        private BaseElement _element;

        public BaseForm(BaseElement element)
        {
            _element = element;
        }

        public bool IsDisplayed()
        {
            return _element.IsDisplayed();
        }
    }
}