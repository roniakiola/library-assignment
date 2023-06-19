public interface IBorrowable
{
  bool CanBorrow { get; }
  void Borrow();
  void Return();
}