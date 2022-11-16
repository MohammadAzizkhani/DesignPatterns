namespace MementoPattern.Sample;

public class History
{
    public Stack<EditorState> States { get; set; } =  new();


    public EditorState Pop()
    {
        return States.Pop();
    }

    public void Push(EditorState state)
    {
        States.Push(state);
    }
}