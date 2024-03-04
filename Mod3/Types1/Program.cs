namespace Types1;

enum Dagen : long
{
    Zondag = 1,
    Maandag = 2,
    Dinsdag = 4,
    Woensdag = 8,
    Donderdag = 16,
    Vrijdag = 32,
    Zaterdag = 64
}

class Program
{
    static void Main(string[] args)
    {
        Types1.Dagen dag1 = Dagen.Woensdag;
        System.Console.WriteLine((int)dag1);

        int dag = 5;
        System.Console.WriteLine((Dagen)dag);
    }
}
