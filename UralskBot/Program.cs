using UralskBot.Pages;

namespace UralskBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser.GetDriver().Navigate().GoToUrl("https://q.midpass.ru/");

            var mainPage = new MainPage();
            mainPage.SelectCountry("Казахстан");
            mainPage.SelectServicesProvider("Уральск - Генеральное консульство");
            mainPage.EnterEmail("example@e.com");
            
            // change keys
            mainPage.EnterCaptcha("1234");

            mainPage.EnterPassword("12345678");

            // удалить
            Thread.Sleep(100000);
        }
    }
}