namespace MementoPattern.Sample;

public class Editor
{
    public string Content { get; set; }

    // restore 
    public void Restore(EditorState editorState)
    {
        Content = editorState.Content;
    }

    // CreateState 
    public EditorState CreateState()
    {
        return new EditorState(Content);
    }
}