namespace Wetenschap;

public class Complex
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public static Complex operator+(Complex a1, Complex a2)
    {
        return new Complex{Real = a1.Real + a2.Real, Imaginary = a1.Imaginary + a2.Imaginary};
    }

    public void Show()
    {
        Console.WriteLine($"({Real} + {Imaginary}i)");
    }
}
