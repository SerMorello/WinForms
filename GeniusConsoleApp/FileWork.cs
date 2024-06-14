using Newtonsoft.Json;
public static class FileWork
{
    public static void Serialize<T>(T obj, string filePath)
    {
        var serializer = new JsonSerializer();

        using (var sw = new StreamWriter(filePath))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            serializer.Serialize(writer, obj);
        }
    }

    public static T Deserialize<T>(string path)
    {
        var serializer = new JsonSerializer();

        using (var sw = new StreamReader(path))
        using (var reader = new JsonTextReader(sw))
        {
            T obj = default(T);
            
            return (T)serializer.Deserialize(reader);
        }
    }
}