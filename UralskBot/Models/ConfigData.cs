using UralskBot.Models.DTOs;

namespace UralskBot.Models
{
    public class ConfigData
    {
        private const string configDataPath = @"Data\ConfigData.json";

        private static ConfigDataDTO _configData = FileReaderUtils.GetData<ConfigDataDTO>(configDataPath);

        static ConfigData()
        {
            Timeout = _configData.Timeout;
            TwoCaptchaApiKey = _configData.TwoCaptchaApiKey;
            Url = _configData.Url;
            Country = _configData.Country;
            Department = _configData.Department;
            CaptchaDirectory = _configData.CaptchaDirectory;
            CaptchaFileName = _configData.CaptchaFileName;
        }

        public static int Timeout { get; }
        public static string TwoCaptchaApiKey { get; }
        public static string Url { get; }            
        public static string Country { get; }
        public static string Department { get; }
        public static string CaptchaDirectory { get; set; }
        public static string CaptchaFileName { get; set; }
    }
}