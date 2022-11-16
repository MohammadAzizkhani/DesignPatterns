namespace StatePattern;

public class ConcreteStateB : IState
{
    public void Handle()
    {
        Console.WriteLine("ConcreteStateA Acting");
    }
}