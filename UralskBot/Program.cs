using UralskBot.Models;
using UralskBot.Pages;

namespace UralskBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser.GetDriver().Navigate().GoToUrl(ConfigData.Url);

            var mainPage = new MainPage();
            mainPage.SelectCountry(ConfigData.Country);
            mainPage.SelectServicesProvider(ConfigData.Department);
            mainPage.EnterEmail(UsersData.Email);
            mainPage.EnterPassword(UsersData.Password);

            var captchaText = mainPage.GetCaptchaText();
            Console.WriteLine($"Captcha text: { captchaText }");
            
            //mainPage.EnterCaptcha(captchaText);

            //mainPage.ClickLogInButton();

            // удалить
            Thread.Sleep(100000);
        }
    }
}