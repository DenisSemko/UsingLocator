namespace ReSharperPlugin.UsingLocator.Helpers;

public static class FileHandler
{
    public static void CreateOrUpdateFile(IProject project, string text, string path)
    {
        if (!File.Exists(path))
        {
            AddNewItemHelper.AddFile(project, path, text);
        }
        else
        {
            File.AppendAllText(path, '\n' + text);
        }
    }
}