using Newtonsoft.Json;
public static class FileWork
{
    public static void Write(string value, string filePath)
    {
        using (var sw = new StreamWriter(filePath, false))
        {
            sw.WriteLine(value);
        }
        Console.WriteLine(  "Записал");
    }

    public static string Read(string path)
    {
        string value = "";
        using (var sw = new StreamReader(path))
        {
            value = sw.ReadToEnd();
        }
        return value;
    }
    public static bool CheckFile(string path)
    {
        if (!File.Exists(path))
        {
            return false;
        }
        return true;
    }
}
