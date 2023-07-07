using UralskBot.Models.DTOs;

namespace UralskBot.Models
{
    public static class TestData
    {
        private const string testDataPath = "TestData.json";

        private static TestDataDTO _testData = FileReaderUtils.GetData<TestDataDTO>(testDataPath);

        static TestData()
        {
            HostUrl = _testData.HostUrl;
            MostPlayedPath = _testData.MostPlayedPath;
        }

        public static string HostUrl { get; set; }

        public static string MostPlayedPath { get; set; }
    }
}