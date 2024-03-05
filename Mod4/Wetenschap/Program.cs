namespace Wetenschap;

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex {Real=10, Imaginary=20};
        c1.Show();

        Complex c2 = new Complex {Real=100, Imaginary=200};
        c2.Show();

        Complex c3 = c1 + c2;
        c3.Show();
    }
}
