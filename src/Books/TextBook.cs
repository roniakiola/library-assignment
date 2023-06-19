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

    public string Borrow()
    {
      return $"borrowed textbook: {Title}";
    }

    public string Return()
    {
      return $"returned textbook: {Title}";
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