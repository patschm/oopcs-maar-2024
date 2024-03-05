namespace Woningbouw;

public class Etage
{
    public static Lift _lift = new Lift();
    public int EtageNummer { get; set; }

    public void CallLift()
    {
        _lift.Call(EtageNummer);
    }
    public void ToonLiftStatus()
    {
        Console.WriteLine($"De lift staat op de {_lift.CurrentFloor}e verdieping");
    }
    static Etage()
    {
        System.Console.WriteLine("Statisch");
    }
}
