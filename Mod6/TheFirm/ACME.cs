namespace TheFirm;

public class ACME
{
    private List<IContract> werknemers = new List<IContract>();

    public void Hire(IContract w)
    {
        werknemers.Add(w);
    }

    public void StartProducing()
    {
        System.Console.WriteLine("ACME starts producting stuff");
        foreach (var wn in werknemers)
        {
            wn.VoerUit();
        }
    }
}
