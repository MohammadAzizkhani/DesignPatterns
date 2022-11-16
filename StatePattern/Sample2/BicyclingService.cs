namespace StatePattern.Sample2;

public class BicyclingService : IDirectionService
{
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (bicycling)");
        return 2;
    }

    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (bicycling)");
        return 2;
    }
}