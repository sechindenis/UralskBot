using UralskBot.Models;
using UralskBot.Pages;
using WindowsInput;
using WindowsInput.Native;

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
            mainPage.EnterCaptcha();
            mainPage.ClickLogInButton();

            // удалить
            Thread.Sleep(100000);
        }
    }
}