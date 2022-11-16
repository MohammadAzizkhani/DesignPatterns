namespace StatePattern.Sample2;

public class DirectionService
{
    private readonly IDirectionService _directionService;

    public DirectionService(IDirectionService directionService)
    {
        _directionService = directionService;
    }

    public object GetEta()
    {
        return _directionService.GetEta();
    }

    public object GetDirection()
    {
        return _directionService.GetDirection();
    }
}