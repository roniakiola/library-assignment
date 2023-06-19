public interface IBorrowable
{
  bool CanBorrow { get; }
  string Borrow();
  string Return();
}