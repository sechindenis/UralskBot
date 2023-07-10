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
            
            // to change
            mainPage.EnterCaptcha(Console.ReadLine());
            //mainPage.EnterCaptcha();
            mainPage.ClickLogInButton();

            Thread.Sleep(3000);

            var firstStepServiceSelection = new FirstStepServiceSelection();
            firstStepServiceSelection.ScrollToForeignPassportTenYearsButton();
            firstStepServiceSelection.ClickForeignPassportTenYearsButton();

            //var secondStepDateSelection = new SecondStepDateSelection();
            //secondStepDateSelection.ClickDateButton();

            // удалить
            Thread.Sleep(100000);
        }
    }
}