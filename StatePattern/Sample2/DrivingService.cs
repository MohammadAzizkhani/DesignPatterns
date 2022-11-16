namespace StatePattern.Sample2;

public class DrivingService : IDirectionService
{
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (driving)");
        return 1;
    }

    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (driving)");
        return 1;
    }
}