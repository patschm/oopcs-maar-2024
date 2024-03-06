using System.Security.Principal;

namespace HetCern;

public delegate int MathDel(int x, int y);

public class WillemKlein
{
    public void Bereken(MathDel fun, int a, int b)
    {
        Console.WriteLine("Willem gaat rekenen...");
        int result = fun(a,b);
        Console.WriteLine($"De uitkomst is {result}");
    }
}