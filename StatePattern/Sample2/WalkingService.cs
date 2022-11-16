namespace StatePattern.Sample2;

public class WalkingService : IDirectionService
{
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (walking)");
        return 4;
    }

    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (walking)");
        return 4;
    }
}