namespace src.Books
{
  public class Comic : Book, IBorrowable
  {
    public string Artist { get; set; }
    public override bool CanBorrow => true;

    public Comic(string title, string author, string publicationYear, string artist)
    : base(title, author, publicationYear)
    {
      Artist = artist;
    }

    public void Borrow()
    {
      Console.WriteLine($"Borrowed comic: {Title}");
    }

    public void Return()
    {
      Console.WriteLine($"Returned comic: {Title}");
    }

    public override void PrintInfo()
    {
      base.PrintInfo();
      Console.Write($", Artist: {Artist}");
    }
  }
}