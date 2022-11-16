namespace MementoPattern;

public class Originator
{
    public string Content { get; set; }

    public Memento CreateState()
    {
        return new Memento(Content);
    }

    public void Restore(Memento memento)
    {
        Content = memento.Content;
    }
}