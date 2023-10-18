namespace ReSharperPlugin.UsingLocator.Helpers;

public static class TextHandler
{
    public static string AddGlobalPrefix(ITextControlSelection selection)
    {
        List<string> globalStatements = new List<string>();
        IList<string> selectedText = selection.GetSelectedText();
        string[] dividedText = selectedText[0].Split('\n');
        
        foreach (var line in dividedText)
        {
            string[] statements = line.Split(';');
            
            foreach (var statement in statements)
            {
                if (!string.IsNullOrWhiteSpace(statement))
                {
                    globalStatements.Add("global " + statement.Trim() + ";");
                }
            }
        }
        
        return string.Join(Environment.NewLine, globalStatements);
    }

    public static void SortAndRemoveDuplicates(string path)
    {
        string[] lines = File.ReadAllLines(path);
        string[] uniqueSortedLines = lines.Distinct().Where(line => !string.IsNullOrWhiteSpace(line)).OrderBy(x => x).ToArray();

        File.WriteAllLines(path, uniqueSortedLines);
    }

    public static void RemoveWhiteSpaces(IDocument document, int startIndex)
    {
        string text = document.GetText();
        int endIndex = text.IndexOf("namespace");

        if (endIndex > startIndex)
        {
            TextRange rangeToDelete = new(startIndex, endIndex);
            string rangeText = text.Substring(startIndex, endIndex - startIndex);

            if (rangeText.All(c => char.IsWhiteSpace(c)))
            {
                document.DeleteText(rangeToDelete);
            }
        }
    }
}