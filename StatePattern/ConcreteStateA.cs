namespace StatePattern;

public class ConcreteStateA : IState
{
    public void Handle()
    {
        Console.WriteLine("ConcreteStateA Acting");
    }
}