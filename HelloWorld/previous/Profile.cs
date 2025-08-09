using System.Collections.Generic;
using HelloWorld;

namespace HelloWorld.previous
{
  class Profile(string name, int age, string city, string country, Pronouns pronouns = Pronouns.TheyThem)
  {
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string City { get; set; } = city;
    public string Country { get; set; } = country;
    public Pronouns Pronouns { get; set; } = pronouns;
    public List<string> Hobbies { get; set; } = [];

    public void ViewProfile()
    {
      Console.WriteLine($"Profile of {Name} ({Pronouns}):");
      Console.WriteLine($"Age: {Age}, Location: {City}, {Country}");
      if (Hobbies.Count > 0)
      {
        Console.WriteLine("Hobbies: " + string.Join(", ", Hobbies));
      }
      else
      {
        Console.WriteLine("No hobbies listed.");
      }
    }

    public override string ToString()
    {
      return $"Name: {Name}, Age: {Age}, Location: {City}, {Country}, Pronouns: {Pronouns}";
    }
  }
}