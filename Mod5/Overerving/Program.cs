namespace Overerving;

class Program
{
    static void Main(string[] args)
    {
        // Generaliseren.
        // TL is een lamp
        TL tl1 = new TL(500) {Kleur = ConsoleColor.Yellow};
        if (tl1 is TL) 
        {
            (tl1 as TL)!.Startijd = 7; // Leg vergrootglas erop
        }
        tl1.Aan();

        HandleTL(tl1);
    }

    static void HandleTL(Lamp t)
    {
        t.Aan();
    }
}
