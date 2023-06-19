namespace src.Books
{
  public class Novel : Book, IBorrowable
  {
    public string Genre { get; set; }
    public override bool CanBorrow => true;

    public Novel(string title, string author, string publicationYear, string genre)
        : base(title, author, publicationYear)
    {
      Genre = genre;
    }

    public void Borrow()
    {
      Console.WriteLine($"Borrowed novel: {Title}");
    }

    public void Return()
    {
      Console.WriteLine($"Returned novel: {Title}");
    }

    public override void PrintInfo()
    {
      base.PrintInfo();
      Console.Write($", Genre: {Genre}");
    }
  }
}