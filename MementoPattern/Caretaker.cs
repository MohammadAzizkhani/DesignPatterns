namespace MementoPattern;

public class Caretaker
{
    public Stack<Memento> States { get; set; } = new();


    public Memento Pop()
    {
        return States.Pop();
    }

    public void Push(Memento state)
    {
        States.Push(state);
    }
}