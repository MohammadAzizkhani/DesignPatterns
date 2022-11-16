namespace MementoPattern;

public class Caretaker
{
    private readonly Stack<Memento> _states = new();

    public Memento Pop()
    {
        return _states.Pop();
    }

    public void Push(Memento state)
    {
        _states.Push(state);
    }
}