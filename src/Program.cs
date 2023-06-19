using src.Library;
using src.Users;
using src.Books;

Library library = new Library();
Customer customer = new Customer("TestCustomer");
Comic comic = new Comic("title", "author", "1997", "John Doe");
library.AddUser(customer);
library.AddBook(comic);

Customer.Library = library;

customer.BorrowBook(comic.ISBN);
customer.ReturnBook(comic.ISBN);
library.RemoveBook(comic.ISBN);
library.RemoveUser(customer);
comic.PrintInfo();

