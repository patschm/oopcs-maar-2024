




namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        //Intro();
        //BitAdvanced();
        NogIetsGeavanceerder();
    }

    private static void NogIetsGeavanceerder()
    {
        int x;
        DoeIets(out x);
        System.Console.WriteLine(x);
    }

    private static void DoeIets(out int y)
    {
        y = 100;
        System.Console.WriteLine(y);
    }

    private static void BitAdvanced()
    {
       //int result = TelOp(1,2, 3, 4, 5, 6, 7);
       int result = TelOp(c:10);
       System.Console.WriteLine(result);
    }

    static int TelOp(int a, int b)
    {
        return a + b;
    }
    static int TelOp(int a = 10, int b = 5, int c = 2)
    {
        return a + b + c;
    }
    static int TelOp(params int[] arr)
    {
        return arr.Sum();
    }


    private static void Intro()
    {
        WelkomsScherm();
        var naam = GeefNaam();
        ToonNaam(naam);
        AfscheidsBericht();
    }

    static void AfscheidsBericht()
    {
        System.Console.WriteLine("Tot ziens");
    }

    // Procedure. Set van instructies die niks teruggeven.
    static void WelkomsScherm()
    {
        System.Console.WriteLine("Welkom bij Name & Co");
    }

    // Function. Geeft iets terug. In dit geval een string
    static string? GeefNaam()
    {
        System.Console.WriteLine("Geef uw naam");
        string? name = Console.ReadLine();
        return name;
    }
    // Procedure met argument
    static void ToonNaam(string? name)
    {
        System.Console.WriteLine($"Uw naam is {name}");
    }
}
