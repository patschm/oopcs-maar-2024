namespace Modellen;

class Program
{
    static void Main(string[] args)
    {
        Lamp lamp1 = new Lamp(500);
        //lamp1._intensiteit = -400;
        //lamp1.kleur = ConsoleColor.DarkYellow;
        lamp1.Intensiteit = 1800;
        lamp1.Aan();
    }
}
