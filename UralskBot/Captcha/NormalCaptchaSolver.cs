using TwoCaptcha.Captcha;
using UralskBot.Models;

namespace UralskBot.Captcha
{
    public class NormalCaptchaSolver
    {
        private static TwoCaptcha.TwoCaptcha _solver = new(ConfigData.TwoCaptchaApiKey);
        private static Normal _normalCaptcha = new();

        public string Language { get; set; } = "en";
        public int SleepTime { get; set; } = 30000;
        public int MinLength { get; set; } = 4;
        public int MaxLength { get; set; } = 10;
        public int DefaultTimeout { get; set; } = 120;
        public int RecaptchaTimeout { get; set; } = 600;
        public bool CaseSensitive { get; set; } = true;

        public NormalCaptchaSolver()
        {
            _solver.DefaultTimeout = DefaultTimeout;
            _solver.RecaptchaTimeout = RecaptchaTimeout;

            _normalCaptcha.SetFile(ConfigData.CaptchaFileName);
            _normalCaptcha.SetMinLen(MinLength);
            _normalCaptcha.SetMaxLen(MaxLength);
            _normalCaptcha.SetCaseSensitive(CaseSensitive);
            _normalCaptcha.SetLang(Language);
        }

        public string? GetCaptchaText()
        {
            string? code = null;

            try
            {
                code = GetText().Result;
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occurred: " + e.InnerExceptions.First().Message);
            }

            return code;
        }

        private async Task<string> GetText()
        {
            var captchaId = await _solver.Send(_normalCaptcha);

            Thread.Sleep(SleepTime);

            var code = await _solver.GetResult(captchaId);

            return code;
        }
    }
}