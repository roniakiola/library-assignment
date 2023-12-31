namespace src.Books
{
  public abstract class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; private set; }
    public string PublicationYear { get; set; }
    public virtual bool CanBorrow { get; }
    public virtual bool CanPrint { get; }

    public Book(string title, string author, string publicationYear)
    {
      Title = title;
      Author = author;
      ISBN = Guid.NewGuid().ToString();
      PublicationYear = publicationYear;
    }

    public virtual void PrintInfo()
    {
      Console.Write($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication Year: {PublicationYear}");
    }
  }
}