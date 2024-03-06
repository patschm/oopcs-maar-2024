// See https://aka.ms/new-console-template for more information

using Toepassing;

List <Person> people = new Bogus.Faker<Person>()
    .RuleFor(p=>p.FirstName, f=>f.Name.FirstName())
    .RuleFor(p=>p.LastName, f=>f.Name.LastName())
    .RuleFor(p=>p.Age, f=>f.Random.Int(0, 123))
    .Generate(100)
    .ToList();

string first = "B";
var query =people.Where(p=>p.FirstName.StartsWith("C")).OrderBy(p=>p.Age);


foreach(var p in query)
{
    System.Console.WriteLine(p);
}

bool FirstNameStartsWithA(Person p)
{
    return p.FirstName.StartsWith(first);
}
    