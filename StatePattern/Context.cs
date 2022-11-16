namespace StatePattern;

internal class Context
{
    private readonly IState _state;
    public Context(IState state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle();
    }
}