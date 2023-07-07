namespace UralskBot.Models.DTOs
{
    [JsonObject]
    public class ConfigDataDTO
    {
        public int Timeout { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
    }
}