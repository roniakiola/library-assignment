using src.Books;
using src.Users;

namespace src.Library
{
  public class Library
  {
    private List<Book> books { get; set; }
    private List<Book> _borrowedBooks { get; set; }
    private List<Person> users { get; set; }

    public Library()
    {
      books = new List<Book>();
      _borrowedBooks = new List<Book>();
      users = new List<Person>();
    }

    public void AddBook(Book book)
    {
      books.Add(book);
      Console.WriteLine($"{book.Title} added");
    }

    public void RemoveBook(string bookId)
    {
      Book book = FindBookById(bookId);
      if (book != null)
      {
        books.Remove(book);
        Console.WriteLine($"{book.Title} removed");
      }
      else
      {
        Console.WriteLine($"Book ID {bookId} not found");
      }
    }

    public void BorrowBook(string bookId, Customer customer)
    {
      Book book = FindBookById(bookId);
      if (book != null && book is IBorrowable borrowable)
      {
        if (!_borrowedBooks.Contains(book))
        {
          _borrowedBooks.Add(book);
          customer.BorrowedBooks.Add(book);
          Console.WriteLine($"{customer.Name} {borrowable.Borrow()}");
        }
        else
        {
          Console.WriteLine("Book already borrowed");
        }
      }
      else
      {
        Console.WriteLine($"Book ID {bookId} not found");
      }
    }

    public void ReturnBook(string bookId, Customer customer)
    {
      Book book = FindBookById(bookId);
      if (book != null && book is IBorrowable borrowable)
      {
        if (_borrowedBooks.Contains(book))
        {
          _borrowedBooks.Remove(book);
          customer.BorrowedBooks.Remove(book);
          Console.WriteLine($"{customer.Name} {borrowable.Return()}");
        }
        else
        {
          Console.WriteLine("This book is not borrowed from this library");
        }
      }
      else
      {
        Console.WriteLine($"Book ID {bookId} not found");
      }
    }

    public void AddUser(Person person)
    {
      users.Add(person);
      Console.WriteLine($"{person.Name} added");
    }

    public void RemoveUser(Person person)
    {
      users.Remove(person);
      Console.WriteLine($"{person.Name} removed");
    }

    public void EditUser(Person person, string newName)
    {
      string oldName = person.Name;
      person.Name = newName;
      Console.WriteLine($"Changed {oldName}'s name to {newName}");
    }

    public Book FindBookById(string bookId)
    {
      return books.Find(b => b.ISBN == bookId);
    }
  }
}