namespace src.Books
{
  public class ResearchPaper : Book, IPrintable
  {
    public int PrintablePages { get; set; }
    public override bool CanPrint => true;

    public ResearchPaper(string title, string author, string publicationYear, int printablePages)
        : base(title, author, publicationYear)
    {
      PrintablePages = printablePages;
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