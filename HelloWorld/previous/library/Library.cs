namespace HelloWorld.previous.library
{
  class Library
  {
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
      books.Add(book);
    }

    public void RemoveBook(Book book)
    {
      books.Remove(book);
    }

    public Book FindBook(string title)
    {
      return books.FirstOrDefault(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
             ?? throw new ArgumentException("Book not found");
    }

    public void ShowBooks()
    {
      foreach (var book in books)
      {
        book.GetInfo();
        Console.WriteLine();
      }
    }
  }
}