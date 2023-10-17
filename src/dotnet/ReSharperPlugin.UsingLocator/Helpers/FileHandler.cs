namespace ReSharperPlugin.UsingLocator.Helpers;

public static class FileHandler
{
    public static void CreateOrUpdateFile(string text, string path)
    {
        if (!File.Exists(path))
        {
            File.WriteAllText(path, text);
        }
        else
        {
            File.AppendAllText(path, text);
        }
    }
}