namespace StatePattern.Abuse;

internal class WatchTimer
{
    public bool IsRunning { get; set; }

    public void Click()
    {
        if (IsRunning)
        {
            IsRunning = false;
            Console.WriteLine("Stopped");
            
        }
        else
        {
            IsRunning = true;
            Console.WriteLine("Running");
        }
            
    }
}