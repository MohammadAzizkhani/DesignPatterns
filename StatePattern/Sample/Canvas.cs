namespace StatePattern.Sample;

public class Canvas
{
    private readonly ITool _tool;

    public Canvas(ITool tool)
    {
        _tool = tool;
    }
    public void MouseDown()
    {
        _tool.MouseDown();
    }

    public void MouseUp()
    {
        _tool.MouseUp();
    }
}