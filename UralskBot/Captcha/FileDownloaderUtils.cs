using System.Net;

namespace UralskBot.Captcha
{
    public class FileDownloaderUtils
    {
        public void DownloadFile(string url, string fileName)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(new Uri(url), fileName);
            }
        }

        public void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }
    }
}