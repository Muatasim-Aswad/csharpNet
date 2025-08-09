using System.Reflection;

namespace HelloWorld.previous.inheritance
{
  public class Resource(string title, string category, string status = "Available")
  {
    public string Title { get; set; } = title;
    public string Category { get; set; } = category;
    public string Status { get; set; } = status;

    public virtual void UpdateStatus()
    {
      Status = Status.Equals("Available") ? "Out" : "Available";
    }

    public void GetInfo()
    {
      Console.WriteLine($"Title: {Title}");
      Console.WriteLine($"Category: {Category}");
      Console.WriteLine($"Status: {Status}");
    }
  }
}