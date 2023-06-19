using src.Books;

namespace src.Users
{
  public class Librarian : Person
  {
    public static Library.Library Library { get; set; }

    public Librarian(string name) : base(name) { }

    public void AddBook(Book book)
    {
      Library.AddBook(book, this);
    }

    public void RemoveBook(string bookId)
    {
      Library.RemoveBook(bookId, this);
    }

    public void EditBook(string bookId, string? newTitle = null, string? newAuthor = null, string? newPublicationYear = null)
    {
      Book book = Library.FindBookById(bookId);
      if (book != null)
      {
        book.Title = newTitle ?? book.Title;
        book.Author = newAuthor ?? book.Author;
        book.PublicationYear = newPublicationYear ?? book.PublicationYear;
        Console.WriteLine("Book edited successfully");
      }
      else
      {
        Console.WriteLine($"Book ID {bookId} not found");
      }
    }
    public void IssueBook(string bookId, Customer customer)
    {
      Library.BorrowBook(bookId, customer);
    }
  }
}