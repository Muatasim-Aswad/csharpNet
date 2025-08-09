namespace HelloWorld.previous.inheritance
{
  public class Periodical(string title, string category, string period) : Resource(title, category)
  {
    public string Period { get; set; } = period;

    public override void UpdateStatus()
    {
      Status = Status.Equals("Available") ? "In-Use" : "Available";
    }
    public new void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine($"Period: {Period}");
    }
  }
}