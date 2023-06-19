using src.Library;
using src.Users;
using src.Books;

Library library = new Library();
Customer customer = new Customer("TestCustomer");
Librarian librarian = new Librarian("TestLibrarian");
Comic comic = new Comic("title", "author", "1997", "John Doe");
library.AddUser(customer);
library.AddBook(comic);

Customer.Library = library;
Librarian.Library = library;

librarian.EditBook(comic.ISBN, newTitle: "NewTitle");
customer.BorrowBook(comic.ISBN);
customer.ReturnBook(comic.ISBN);
librarian.IssueBook(comic.ISBN, customer);
library.RemoveBook(comic.ISBN);
library.RemoveUser(customer);
comic.PrintInfo();

