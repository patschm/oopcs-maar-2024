

namespace Linq;

class Dummy
{
    public string? First { get; set; }
    public string? Last { get; set; }
}

class Program
{
    static List<Person> people = new List<Person>();

    static void Main(string[] args)
    {
        GenerateData(100);

        var query = people.Select(p => new { p.FirstName, p.LastName });
        var q2 = from p in people 
            where p.LastName.StartsWith("K") 
            orderby p.Age 
            select new { p.FirstName, p.LastName };

        foreach (var d in q2)
        {
            System.Console.WriteLine($"{d.FirstName} {d.LastName}");
        }
        //ShowData(people);
    }

    private static void ShowData(List<Person> people)
    {
        foreach (var p in people)
        {
            System.Console.WriteLine(p);
        }
    }

    private static void GenerateData(int v)
    {
        people = new Bogus.Faker<Person>()
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.Age, f => f.Random.Int(0, 123))
            .Generate(v)
            .ToList();
    }
}
