namespace HelloWorld.previous.library
{
  class Book(string title, string author)
  {
    public string Title { get; set; } = title;
    public string Author { get; set; } = author;

    public void GetInfo()
    {
      Console.WriteLine($"Title: {Title}");
      Console.WriteLine($"Author: {Author}");
    }
  }
}