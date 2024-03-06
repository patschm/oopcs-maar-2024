namespace DeRadio;

public delegate void Methode(string msg);


public class R538
{
    //private Methode? _methodes;

    public event Methode? Methodes;
    // {
    //     add
    //     {
    //         _methodes += value;
    //     }
    //     remove
    //     {
    //         _methodes -= value;
    //     }
    // }
    public void ZendUit()
    {
        System.Console.WriteLine("Begint de uitzending");
        Methodes?.Invoke("Hallo allemaal");
    }
}
