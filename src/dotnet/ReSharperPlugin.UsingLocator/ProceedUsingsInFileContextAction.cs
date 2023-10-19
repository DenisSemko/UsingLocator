namespace ReSharperPlugin.UsingLocator;

[ContextAction(
    Group = CSharpContextActions.GroupID,
    Name = nameof(ProceedUsingsInFileContextAction),
    Description = nameof(ProceedUsingsInFileContextAction),
    Priority = -10)]
public class ProceedUsingsInFileContextAction : ContextActionBase
{
    private readonly ICSharpContextActionDataProvider _provider;

    public ProceedUsingsInFileContextAction(ICSharpContextActionDataProvider provider)
    {
        _provider = provider;
    }
    
    public override string Text => Constants.ContextActionText;
    
    public override bool IsAvailable(IUserDataHolder cache) => 
        !_provider.SourceFile.Name.Equals(Constants.FileName, StringComparison.OrdinalIgnoreCase) && _provider.SelectedElement.GetText().Contains("using");

    protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
    {
        ICSharpFile typeDeclaration = _provider.GetSelectedElement<ICSharpFile>();
        if (typeDeclaration is null)
            return null;

        return textControl =>
        {
            using (WriteLockCookie.Create())
            {
                IDocument document = textControl.Document;
                ITextControlSelection selection = textControl.Selection;
                int caretOffset = _provider.CaretOffset;

                string newText = TextHandler.AddGlobalPrefix(selection);

                IProject project = _provider.PsiFile.GetProject();
                string path = Path.Combine(project.Location.FullPath, Constants.FileName);
                FileHandler.CreateOrUpdateFile(project, newText, path);
                TextHandler.SortAndRemoveDuplicates(path);
                
                document.DeleteText(selection.OneDocRangeWithCaret());
                textControl.Caret.MoveTo(caretOffset + newText.Length, CaretVisualPlacement.DontScrollIfVisible);
                TextHandler.RemoveWhiteSpaces(document, _provider.CaretOffset);
            }
        };
    }
}