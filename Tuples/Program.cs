
namespace Tuples;

class Program
{
    static void Main(string[] args)
    {
        try
        {

        }
        catch (Exception)
        {
            throw;
        }
        finally
        {

        }



        (int, double, string, float, string) val;

        (string, int) x = ("hoi", 42);

        (int Nr, string Text) y = DoeIets();
        ShowTuple(y);
        System.Console.WriteLine(y.Nr);
    }

    private static void ShowTuple((int, string) yx)
    {
        System.Console.WriteLine(yx.Item1);
    }

    static (int, string) DoeIets()
    {
        return (42, "Hallo");
    }
}

class Dummy
{
    public int Nr { get; set; }
    public string? Text { get; set; }
}
