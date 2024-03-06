#define OKx


namespace ItsAMystery;

class Program
{
    static void Main(string[] args)
    {
        Point p = new Point {X=10, Y=20};
        Console.WriteLine(p);
        DoeIets(p);
        Console.WriteLine(p);

    }

    private static void DoeIets(Point p2)
    {
       p2.X = 1000;
       p2.Y = 2000;
    }
}
#if OK
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
#else
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}


#endif
