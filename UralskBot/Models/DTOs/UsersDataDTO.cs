namespace UralskBot.Models.DTOs
{
    [JsonObject]
    public class UsersDataDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}