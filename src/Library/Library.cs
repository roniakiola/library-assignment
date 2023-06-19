using src.Books;
using src.Users;

namespace src.Library
{
  public class Library
  {
    public List<Book> books { get; set; }
    private List<Book> _borrowedBooks { get; set; }
    public List<Person> users { get; set; }

    public Library()
    {
      books = new List<Book>();
      _borrowedBooks = new List<Book>();
      users = new List<Person>();
    }

    public void AddBook(Book book)
    {
      books.Add(book);
    }

    public void RemoveBook(Book book)
    {
      books.Remove(book);
    }

    public void BorrowBook(Book book)
    {
      _borrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
      _borrowedBooks.Remove(book);
    }

    public void AddUser(Person person)
    {
      users.Add(person);
    }

    public void RemoveUser(Person person)
    {
      users.Remove(person);
    }

    public void EditUser(Person person)
    {

    }
  }
}