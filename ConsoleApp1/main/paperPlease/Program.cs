using System;
using PaperPlease;

public class Program
{
    static void Main(string[] args)
    {
        string? path = "C:\\Users\\snowc\\Desktop\\oop labs\\truLab1\\PapersPlease\\PapersPlease\\lab-papers-please\\c#-classification\\src\\main\\resources\\input.json";

        string? outterpath = "C:\\Users\\snowc\\Desktop\\oop labs\\truLab1\\PapersPlease\\PapersPlease\\lab-papers-please\\c#-classification\\src\\main\\resources\\output";

        JsonReader jsonReader = new JsonReader(path);
        EntityData? individuals = jsonReader.GetEntities();

        RuleSet? ruleSet = new(new Dictionary<string, List<Race>>
        {
            ["starWars"] = new List<Race>
            {
                new Race(false, "Kashyyyk", 400, new List<string> { "HAIRY", "TALL" }),
                new Race(false, "Endor", 60, new List<string> { "HAIRY", "SHORT" })
            },
            ["hitchHiker"] = new List<Race>
            {
                new Race(true, "Betelgeuse", 100, new List<string> { "EXTRA_ARMS", "EXTRA_HEAD" }),
                new Race(false, "Vogsphere", 200, new List<string> { "GREEN", "BULKY" })
            },
            ["marvel"] = new List<Race>
            {
                new Race(true, "Asgard", 5000, new List<string> { "BLONDE", "TALL" })
            },
            ["rings"] = new List<Race>
            {
                new Race(true, "Earth", Double.PositiveInfinity, new List<string> { "BLONDE", "POINTY_EARS" }),
                new Race(true, "Earth", 200, new List<string> { "SHORT", "BULKY" })
            }
        });
    }
}


