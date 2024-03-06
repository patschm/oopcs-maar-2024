namespace EvolutieTheorie;

delegate int MathDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        // 2002. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // 2005. Framework 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 10;

        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3,4);

        // 2008. Framwork 3.0/3.5
        
        MathDel m4 = (a, b) => a + b + c;
        result = m4(4, 5);

        // Procdures
        Action<string> a1 = (s)=>System.Console.WriteLine($"Hallo {s}");
        a1("Allemaal");
        // Functions
        Func<int, int, int> f1 = Add;
        
        result = f1(6,7);

        result = InlineAdd(8,9);


        Console.WriteLine($"De uitkomst is {result}");

    

        int InlineAdd(int x, int y)
        {
            return x + y + c;
        }

    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
