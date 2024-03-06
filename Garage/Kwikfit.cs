
namespace Garage;

public delegate void Taak();

public class Kwikfit
{
    public void DoeReparatie(Taak opdracht)
    {
        System.Console.WriteLine("bij de garage...");
        opdracht();
    }
}
