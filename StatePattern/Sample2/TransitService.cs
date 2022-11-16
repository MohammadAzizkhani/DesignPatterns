namespace StatePattern.Sample2;

public class TransitService: IDirectionService
{
    public object GetEta()
    {
        Console.WriteLine("Calculating ETA (transit)");
        return 3;
    }

    public object GetDirection()
    {
        Console.WriteLine("Calculating Direction (transit)");
        return 3;
    }
}