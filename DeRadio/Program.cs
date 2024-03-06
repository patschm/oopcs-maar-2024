namespace DeRadio;

class Program
{
    static void Main(string[] args)
    {
        R538 r = new R538();

        r.Methodes += OntvangstMethode.ViaEther;
        r.Methodes += OntvangstMethode.ViaPostduif;
        r.Methodes += OntvangstMethode.ViaWifi;
        r.Methodes += OntvangstMethode.ViaKabel;
        r.Methodes += OntvangstMethode.ViaEther;
        r.Methodes += OntvangstMethode.ViaPostduif;
        r.Methodes += OntvangstMethode.ViaWifi;
        r.Methodes += OntvangstMethode.ViaKabel;

        r.ZendUit();
    }
}
