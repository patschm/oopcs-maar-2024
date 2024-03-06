namespace Siemens;

public delegate void DetectAction();

public class DetectieLus
{
    public event DetectAction? Detect;
    public void Detecting()
    {
        Console.WriteLine("De detectielus ziet dingen");
        Detect?.Invoke();
    }
}
