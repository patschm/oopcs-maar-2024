
namespace DeRadio;

public static class OntvangstMethode
{
    public static void ViaKabel(string msg)
    {
        System.Console.WriteLine($"Via kabel ontvangen: {msg}");
    }
    public static void ViaEther(string msg)
    {
        System.Console.WriteLine($"Via ether ontvangen: {msg}");
    }
    public static void ViaWifi(string msg)
    {
        System.Console.WriteLine($"Via wifi ontvangen: {msg}");
    }
    public static void ViaPostduif(string msg)
    {
        System.Console.WriteLine($"Via postduif ontvangen: {msg}");
    }
}