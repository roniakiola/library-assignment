namespace src.Book
{
  public class Novel : Book
  {
    public string Genre { get; set; }

    public Novel(string title, string author, string isbn, string publicationYear, bool canBorrow, bool canPrint, string genre)
        : base(title, author, isbn, publicationYear, canBorrow, canPrint)
    {
      Genre = genre;
    }
  }
}