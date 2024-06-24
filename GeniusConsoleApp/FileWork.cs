using Newtonsoft.Json;
public static class FileWork
{
    public static void Serialize<T>(T obj, string filePath)
    {
        var serializer = JsonConvert.SerializeObject(obj, Formatting.Indented);

        using (var sw = new StreamWriter(filePath, true))
        {
            sw.WriteLine(serializer);
        }
    }

    public static string Deserialize(string path)
    {
        using (var sw = new StreamReader(path))
        {
            return sw.ReadToEnd();
        }
    }
    public static void CheckFile(string path)
    {
        if (!File.Exists(path))
        {
            File.Create(path);
        }
    }
}
