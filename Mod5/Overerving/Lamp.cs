namespace Overerving;

abstract class Lamp 
{
    private int _intensiteit = 100;

    protected int Intensiteit
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

    public ConsoleColor Kleur { get; set; } = ConsoleColor.Green;

    // Virtual. Aan-gedrag is nu polymorf-ready
    public virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        System.Console.WriteLine($"De lamp is aan en brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }
    public abstract void Uit();
    // {
    //     Console.WriteLine("De lamp is nu uit");
    // }

    public Lamp(int intensiteit)
    {
        Intensiteit = intensiteit;
    }
}