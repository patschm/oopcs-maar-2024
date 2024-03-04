namespace Modellen;

class Lamp //(ConsoleColor kleur)
{
    // Fields
    // Hierin slaan we de state van het object op.
    //private ConsoleColor _kleur = ConsoleColor.Yellow;
    private int _intensiteit = 100;

    // Encapsulation
    // Old style, zoals men dat in Java en C++ doet.
    // Niet doen. Ter lering en vermeack
    public int GetIntensiteit()
    {
        return _intensiteit;
    }
    public void SetIntensiteit(int value)
    {
        if (value >= 0 && value < 1000)
        {
            _intensiteit = value;
        }
    }

    // Properties
    // .NET versie van encapsulation
    public int Intensiteit
    {
        get
        {
            return _intensiteit;
        }
        set
        {
            if (value >= 0 && value < 1000)
            {
                _intensiteit = value;
            }
        }
    }

    // Auto generating property. Brengt zijn eigen field mee.
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Green;

    // Methods
    // Hierin definieren we het gedrag van de lamp
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        System.Console.WriteLine($"De lamp is aan en brandt met {_intensiteit} lumen");
        Console.ResetColor();
    }
    public void Uit()
    {
        Console.WriteLine("De lamp is nu uit");
    }

    // Constructor
    // Die gebruik je om fields van een initele waarde te voorzien (dwingend)
    public Lamp(int intensiteit)
    {
        _intensiteit = intensiteit;
    }
}