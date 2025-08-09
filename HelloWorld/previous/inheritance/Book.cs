namespace HelloWorld.previous.inheritance
{
  public class Book(string title, string category, string author, int pageCount) : Resource(title, category)
  {
    public string Author { get; set; } = author;
    public int PageCount { get; set; } = pageCount;

    public new void GetInfo()
    {
      base.GetInfo();
      Console.WriteLine($"Author: {Author}");
      Console.WriteLine($"Pages: {PageCount}");
    }
  }
}