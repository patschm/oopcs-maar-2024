
namespace Generieken;

class Program
{
    static void Main(string[] args)
    {
        Point<float> p = new Point<float> {X=10.7F, Y=20.3F};
        System.Console.WriteLine(p);



        decimal a = 10;
        decimal b = 20;
        System.Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        System.Console.WriteLine($"a={a}, b={b}");
    }

    private static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }
    // private static void Swap(ref float a, ref float b)
    // {
    //     float tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // private static void Swap(ref long a, ref long b)
    // {
    //     long tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // private static void Swap(ref int a, ref int b)
    // {
    //     int tmp = a;
    //     a = b;
    //     b = tmp;
    // }
}
