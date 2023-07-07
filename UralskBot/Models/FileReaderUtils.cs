namespace UralskBot.Models
{
    public class FileReaderUtils
    {
        public static TDataDTO GetData<TDataDTO>(string dataPath) where TDataDTO : new()
        {
            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            TDataDTO data = new();

            using (var streamReader = new StreamReader(dataPath))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                data = serializer.Deserialize<TDataDTO>(jsonTextReader);
            }

            return data;
        }
    }
}