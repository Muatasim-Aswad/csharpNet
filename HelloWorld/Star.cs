namespace HelloWorld
{
  public class Star(string name, string type)
  {
    // add getters and setters for properties
    private string name = name;
    private string type = type;
    private int age = 0; // in years
    private double brightness = 1.0; // arbitrary brightness scale

    public string Comments { get; } = string.Empty;
    public string ExtraInfo
    {
      get => $"Star {name} of type {type} is {age} years old with brightness {brightness}. {Comments}";
      set => _comments += value;
    }

    public Star(string name) : this(name, "Unknown")
    {
      Console.WriteLine($"Star {name} created with default type 'Unknown'.");
    }

    public void Shine()
    {
      Console.WriteLine($"{name} is shining with brightness {brightness}.");
    }

    public void GrowOlder()
    {
      age++;
      brightness -= brightness * 0.1; // Decrease brightness over time by 10%
      Console.WriteLine($"{name} is now {age} years old and has brightness {brightness}.");
    }
    public void Supernova()
    {
      brightness = 0.0; // Brightness drops to zero after supernova
      Console.WriteLine($"{name} of type {type} has gone supernova!");
    }


  }
}