using OpenQA.Selenium.Support.UI;
using UralskBot.Elements;

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

        private SelectElement countriesSelectElement;
        private SelectElement servicesProviderSelectElement;
        private TextBoxElement emailTextBoxElement;
        private TextBoxElement captchaTextBoxElement;
        private TextBoxElement passwordTextBoxElement;
        private ButtonElement logInButtonElement;

        public MainPage()
        {
            countriesSelectElement = new SelectElement(Browser.GetDriver().FindElement(By.XPath($"{ countriesSelectElemenXPath }")));
            servicesProviderSelectElement = new SelectElement(Browser.GetDriver().FindElement(By.XPath($"{ servicesProviderSelectElemenXPath }")));
            emailTextBoxElement = new TextBoxElement(Browser.GetDriver().FindElement(By.XPath($"{ emailTextBoxElemenXPath }")));
            captchaTextBoxElement = new TextBoxElement(Browser.GetDriver().FindElement(By.XPath($"{ captchaTextBoxElemenXPath }")));
            passwordTextBoxElement = new TextBoxElement(Browser.GetDriver().FindElement(By.XPath($"{ passwordTextBoxElemenXPath }")));
            logInButtonElement = new ButtonElement(Browser.GetDriver().FindElement(By.XPath($"{ logInButtonXPath }")));
        }

        public void SelectCountry(string country)
        {
            countriesSelectElement.SelectByText(country);
        }

        public void SelectServicesProvider(string servicesProvider)
        {
            servicesProviderSelectElement.SelectByText(servicesProvider);
        }

        public void EnterEmail(string email)
        {
            emailTextBoxElement.SendKeys(email);
        }

        public void EnterCaptcha(string captcha)
        {
            captchaTextBoxElement.SendKeys(captcha);
        }

        public void EnterPassword(string password)
        {
            passwordTextBoxElement.SendKeys(password);
        }

        public void ClickLogInButton()
        {
            logInButtonElement.Click();
        }
    }
}