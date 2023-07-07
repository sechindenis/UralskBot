using UralskBot.Models.DTOs;

namespace UralskBot.Models
{
    public static class UsersData
    {
        private const string usersDataPath = @"Data\UsersData.json";

        private static UsersDataDTO _usersData = FileReaderUtils.GetData<UsersDataDTO>(usersDataPath);

        static UsersData()
        {
            Email = _usersData.Email;
            Password = _usersData.Password;
        }

        public static string Email { get; }

        public static string Password { get; }
    }
}