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
            
            // change keys
            mainPage.EnterCaptcha(Console.ReadLine());

            mainPage.EnterPassword(UsersData.Password);
            mainPage.ClickLogInButton();

            // удалить
            Thread.Sleep(100000);
        }
    }
}