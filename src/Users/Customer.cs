using src.Books;

namespace src.Users
{
  public class Customer : Person
  {
    public List<Book> BorrowedBooks { get; set; }
    public static Library.Library Library { get; set; }

    public Customer(string name) : base(name)
    {
      BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(string bookId)
    {
      Library.BorrowBook(bookId, this);
    }

    public void ReturnBook(string bookId)
    {
      Library.ReturnBook(bookId, this);
    }
  }
}