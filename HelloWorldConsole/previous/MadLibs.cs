
namespace HelloWorld.previous
{
  public class MadLibs
  {
    public static void Run()
    {
      Console.WriteLine("Starting the Mad Libs game...");

      string title = "Mad Libs Adventure";
      Console.WriteLine(title);

      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine() ?? string.Empty;

      Console.Write("Enter the first adjective: ");
      string firstAdjective = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter the second adjective: ");
      string secondAdjective = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter the third adjective: ");
      string thirdAdjective = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter the first noun: ");
      string firstNoun = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter the second noun: ");
      string secondNoun = Console.ReadLine() ?? string.Empty;

      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a food: ");
      string food = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a superhero name: ");
      string superhero = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a country: ");
      string country = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine() ?? string.Empty;
      Console.Write("Enter a year: ");
      string year = Console.ReadLine() ?? string.Empty;

      // The template for the story:
      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {dessert} in a puddle of frozen {fruit}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";

      // Print the story:
      Console.WriteLine(story);
    }
  }
}