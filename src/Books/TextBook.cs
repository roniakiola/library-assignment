namespace src.Books
{
  public class TextBook : Book, IBorrowable, IPrintable
  {
    public int PrintablePages { get; set; }
    public override bool CanBorrow => true;
    public override bool CanPrint => true;

    public TextBook(string title, string author, string publicationYear, int printablePages)
        : base(title, author, publicationYear)
    {
      PrintablePages = printablePages;
    }

    public void Borrow()
    {
      Console.WriteLine($"Borrowed textbook: {Title}");
    }

    public void Return()
    {
      Console.WriteLine($"Returned textbook: {Title}");
    }

    public void PrintPages(int startPage, int endPage)
    {
      if (endPage - startPage <= PrintablePages)
      {
        Console.WriteLine($"Printing pages from page {startPage} to {endPage}");
      }
      else
      {
        Console.WriteLine($"Maximum printable pages is {PrintablePages}. Please provide valid amount");
      }
    }
  }
}