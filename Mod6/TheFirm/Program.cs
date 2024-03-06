namespace TheFirm;

class Program
{
    static void Main(string[] args)
    {
        IContract p = new Patrick();
        Florian f = new Florian();
        Bokito b = new Bokito();
        ACME company = new ACME();

        company.Hire(f);
        company.Hire(p);
        company.Hire(b);

        company.StartProducing();
    }
}
