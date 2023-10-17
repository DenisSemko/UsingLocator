namespace ReSharperPlugin.UsingLocator.Helpers;

public static class TextHandler
{
    public static string AddGlobalPrefix(ITextControlSelection selection)
    {
        IList<string> selectedText = selection.GetSelectedText();
        string[] dividedText = selectedText[0].Split('\n');
        for (int i = 0; i < dividedText.Length; i++)
        {
            dividedText[i] = "global " + dividedText[i];
        }
        return string.Join(Environment.NewLine, dividedText);
    }

    public static void SortAndRemoveDuplicates(string path)
    {
        string[] lines = File.ReadAllLines(path);
        string[] uniqueSortedLines = lines.Distinct().OrderBy(x => x).ToArray();

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