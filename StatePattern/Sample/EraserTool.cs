namespace StatePattern.Sample;

internal class EraserTool : ITool
{
    public void MouseDown()
    {
        Console.WriteLine("Eraser Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Erase Something");
    }
}