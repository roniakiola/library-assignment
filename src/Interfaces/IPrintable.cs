public interface IPrintable
{
  bool CanPrint { get; }
  int PrintablePages { get; set; }
  void PrintPages(int startPage, int endPage);
}