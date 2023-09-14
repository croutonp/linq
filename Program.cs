List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// 1.
// Eruption? Chile = eruptions.Where(c => c.Location == "Chile").OrderBy(c => c.Year).First();
// Console.WriteLine(Chile);

//2.
// Eruption? Hawaii = eruptions.FirstOrDefault(h => h.Location.Contains("Hawaiian Is"));
// if(Hawaii == null)
// {
//     Console.WriteLine("No Hawaiian Is Eruption found");
// } else
// {
//     Console.WriteLine(Hawaii);
// }

// 3.
// Eruption? Greenland= eruptions.FirstOrDefault(h => h.Location.Contains("Greenland"));
// if(Greenland == null)
// {
//     Console.WriteLine("No Greenland Is Eruption found");
// } else
// {
//     Console.WriteLine(Greenland);
// }

//4.
// Eruption? NewZealand = eruptions.Where(n => n.Year > 1900).FirstOrDefault(nameof => nameof.Location == "New Zealand");
// Console.WriteLine(NewZealand);

//5
// IEnumerable<Eruption> GreaterThan2000 = eruptions.Where(g => g.ElevationInMeters > 2000);
// PrintEach(GreaterThan2000, "string");

//6.
// List<Eruption> Start = eruptions.Where(e => e.Volcano.StartsWith("L")).ToList();
// Start.ForEach(Console.WriteLine);
// Console.WriteLine(Start.Count());

//7.
// int HighestElevation = eruptions.Max(he => he.ElevationInMeters);
// Console.WriteLine(HighestElevation);

//8.
// string Tallest = eruptions.Where(t => t.ElevationInMeters == HighestElevation).Select(t => t.Volcano).ToList()[0];
// Console.WriteLine(Tallest);

//9.
// List<String> alphabetically = eruptions.OrderBy(a => a.Volcano).Select(a => a.Volcano).ToList();
// alphabetically.ForEach(Console.WriteLine);

//10.
// int Sum = eruptions.Sum(s => s.ElevationInMeters);
// Console.WriteLine(Sum);

//11.
// bool Any2000 = eruptions.Any(a => a.Year == 2000);
// Console.WriteLine(Any2000);

//12.
// IEnumerable<Eruption> FirstThree = eruptions.Where(f => f.Type == "Stratovolcano").Take(3);
// PrintEach(FirstThree);

//13.
List<String> Before1000 = eruptions.Where(b => b.Year <= 1000).OrderBy(b => b.Volcano).Select(b => b.Volcano).ToList();
Before1000.ForEach(Console.WriteLine);




// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
