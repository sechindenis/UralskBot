using UralskBot.Captcha;
using UralskBot.Elements;
using UralskBot.Models;
using WindowsInput;

namespace UralskBot.Pages
{
    public class MainPage
    {
        private const string countriesSelectElemenXPath = "//*[contains(@class, 'SelInp') and contains(@data-bind, 'countries')]";
        private const string servicesProviderSelectElemenXPath = "//*[contains(@class, 'SelInp') and contains(@data-bind, 'servicesProvider')]";
        private const string emailTextBoxElemenXPath = "//*[contains(@class, 'register_input') and contains(@name, 'Email')]";
        private const string captchaTextBoxElemenXPath = "//*[contains(@class, 'register_input') and contains(@name, 'Captcha')]";
        private const string passwordTextBoxElemenXPath = "//*[contains(@class, 'register_input') and contains(@name, 'Password')]";
        private const string logInButtonXPath = "//*[contains(@onclick, 'LogOn') and contains(text(), 'Войти')]";
        private const string captchaImageXPath = "//*[contains(@id, 'imgCaptcha')]";

        private SelectElement _countriesSelectElement;
        private SelectElement _servicesProviderSelectElement;
        private TextBoxElement _emailTextBoxElement;
        private TextBoxElement _captchaTextBoxElement;
        private TextBoxElement _passwordTextBoxElement;
        private ButtonElement _logInButtonElement;
        private ImageElement _captchaImageElement;

        public MainPage()
        {
            _countriesSelectElement = new SelectElement(Browser.GetDriver().FindElement(By.XPath($"{ countriesSelectElemenXPath }")));
            _servicesProviderSelectElement = new SelectElement(Browser.GetDriver().FindElement(By.XPath($"{ servicesProviderSelectElemenXPath }")));
            _emailTextBoxElement = new TextBoxElement(Browser.GetDriver().FindElement(By.XPath($"{ emailTextBoxElemenXPath }")));
            _captchaTextBoxElement = new TextBoxElement(Browser.GetDriver().FindElement(By.XPath($"{ captchaTextBoxElemenXPath }")));
            _passwordTextBoxElement = new TextBoxElement(Browser.GetDriver().FindElement(By.XPath($"{ passwordTextBoxElemenXPath }")));
            _logInButtonElement = new ButtonElement(Browser.GetDriver().FindElement(By.XPath($"{ logInButtonXPath }")));
            _captchaImageElement = new ImageElement(Browser.GetDriver().FindElement(By.XPath($"{ captchaImageXPath }")));
        }

        public void SelectCountry(string country)
        {
            _countriesSelectElement.SelectByText(country);
        }

        public void SelectServicesProvider(string servicesProvider)
        {
            _servicesProviderSelectElement.SelectByText(servicesProvider);
        }

        public void EnterEmail(string email)
        {
            _emailTextBoxElement.SendKeys(email);
        }

        public void EnterCaptcha()
        {
            _captchaTextBoxElement.SendKeys(GetCaptchaText());
        }

        public void EnterPassword(string password)
        {
            _passwordTextBoxElement.SendKeys(password);
        }

        public void ClickLogInButton()
        {
            _logInButtonElement.Click();
        }

        private string GetCaptchaText()
        {
            MouseHoverCaptchaImage();
            RightClickCaptchaImage();
            EnterCaptchaDownloadingSettings();

            var captchaText = new NormalCaptchaSolver().GetCaptchaText() ?? throw new Exception("Captcha text is null");            

            DeleteCaptchaImage();

            return captchaText;
        }

        private void MouseHoverCaptchaImage()
        {
            new Actions(Browser.GetDriver())
                .MoveToElement(_captchaImageElement.GetElement())
                .Perform();
        }

        private void RightClickCaptchaImage()
        {
            new Actions(Browser.GetDriver())
                .MoveToElement(_captchaImageElement.GetElement())
                .ContextClick()
                .Perform();
        }

        private void EnterCaptchaDownloadingSettings()
        {
            Thread.Sleep(1000);

            var input = new InputSimulator();
            input.Keyboard.KeyPress(VirtualKeyCode.DOWN, VirtualKeyCode.DOWN, VirtualKeyCode.RETURN);
            input.Keyboard.KeyDown(VirtualKeyCode.RETURN);

            Thread.Sleep(1000);

            input.Keyboard.KeyPress(VirtualKeyCode.TAB, VirtualKeyCode.TAB, VirtualKeyCode.TAB);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB, VirtualKeyCode.TAB, VirtualKeyCode.TAB);

            input.Keyboard.KeyDown(VirtualKeyCode.RETURN);
            input.Keyboard.TextEntry(ConfigData.AssemblyLocation);
            input.Keyboard.KeyDown(VirtualKeyCode.RETURN);

            Thread.Sleep(1000);

            input.Keyboard.KeyPress(VirtualKeyCode.TAB, VirtualKeyCode.TAB, VirtualKeyCode.TAB);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB, VirtualKeyCode.TAB, VirtualKeyCode.TAB);
            input.Keyboard.TextEntry(ConfigData.CaptchaFileName);
            input.Keyboard.KeyDown(VirtualKeyCode.RETURN);

            Thread.Sleep(1000);
        }

        private void DeleteCaptchaImage()
        {
            File.Delete(ConfigData.CaptchaFileName);
        }
    }
}