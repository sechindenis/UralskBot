using UralskBot.Models;

namespace UralskBot
{
    public class Browser
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
            }
            
            return _driver;
        }

        public static void SwitchToNewTab(int tabNumber)
        {
            var wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(ConfigData.Timeout));
           
            wait.Until(t => _driver.SwitchTo().Window(_driver.WindowHandles[tabNumber]));
        }

        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}