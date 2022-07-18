namespace Tools
{
    public class JsonFunctions
    {
        public static T DeserializeJson<T>(string fileName) where T : new()
        {
            if (System.IO.File.Exists(@$"..\..\..\{fileName}.json"))
            {
                var json = System.IO.File.ReadAllText(@$"..\..\..\{fileName}.json");
                return System.Text.Json.JsonSerializer.Deserialize<T>(json);
            }
            else
            {
                Console.WriteLine($"The file {fileName}.json not found or moved.");
                return new();
            }
        }
    }
}
