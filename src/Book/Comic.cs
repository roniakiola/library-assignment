namespace src.Book
{
  public class Comic : Book
  {
    public string Artist { get; set; }

    public Comic(string title, string author, string isbn, string publicationYear, bool canBorrow, bool canPrint, string artist)
    : base(title, author, isbn, publicationYear, canBorrow, canPrint)
    {
      Artist = artist;
    }
  }
}