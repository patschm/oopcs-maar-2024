namespace Garage;

class Program
{
    static void Main(string[] args)
    {
        Kwikfit kf = new Kwikfit();
        Patrick ps = new Patrick();

        kf.DoeReparatie(ps.KunnenJullieHiernaarKijken);
    }
}
