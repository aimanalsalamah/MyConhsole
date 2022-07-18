
namespace Tools
{
    public class JsonFunctions
    {
     public static T Deserializejson<T>(string fileName) where T : new()
        {
            if (System.IO.File.Exists($@"..\..\..\{fileName}.json"))
            {
                var json = System.IO.File.ReadAllText($@"..\..\..\{fileName}.json");
                return System.Text.Json.JsonSerializer.Deserialize<T>(json);


            }
            else
            {
                Console.WriteLine($"the fill {fileName}.json not found or moved.");
                return new();
            }
        }

    }
}
