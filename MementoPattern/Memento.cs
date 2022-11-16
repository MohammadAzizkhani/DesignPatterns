namespace MementoPattern;

public class Memento
{
    public Memento(string content)
    {
        Content = content;
    }
    public string Content { get; }

}