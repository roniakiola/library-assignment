namespace src.Book
{
  public abstract class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string PublicationYear { get; set; }
    public bool CanBorrow { get; set; }
    public bool CanPrint { get; set; }

    public Book(string title, string author, string isbn, string publicationYear, bool canBorrow, bool canPrint)
    {
      Title = title;
      Author = author;
      ISBN = isbn;
      PublicationYear = publicationYear;
      CanBorrow = canBorrow;
      CanPrint = canPrint;
    }

    public virtual void PrintInfo()
    {
      Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication Year: {PublicationYear}");
    }
  }
}