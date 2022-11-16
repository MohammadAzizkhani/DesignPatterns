namespace MementoPattern.Sample;

public class History
{
    private readonly Stack<EditorState> _states = new();

    public EditorState Pop()
    {
        return _states.Pop();
    }

    public void Push(EditorState state)
    {
        _states.Push(state);
    }
}