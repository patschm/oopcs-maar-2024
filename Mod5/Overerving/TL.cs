using System.ComponentModel.Design;

namespace Overerving;

class TL : Lamp
{
    public int Startijd { get; set; } = 5;
    
    // override maakt polymorfisme mogenlijk
    public sealed override void Aan()
    {
        for (int i = 0; i < Startijd; i++)
        {
            Console.BackgroundColor = Kleur;
            System.Console.WriteLine($"Knipperdeknipper");
            Task.Delay(200).Wait();
            Console.ResetColor();
            Console.Clear();
        }
        Console.BackgroundColor = Kleur;
        System.Console.WriteLine($"De tl is aan en brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }
    public override void Uit()
    {
        Console.WriteLine("De TL is nu uit");
    }
    public TL(int intensiteit) : base(intensiteit)
    {
    }
}