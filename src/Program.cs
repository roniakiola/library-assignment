using src.Library;
using src.Users;
using src.Books;

Library library = new Library();
Customer.Library = library;
Librarian.Library = library;

Customer customer = new Customer("Timo");
Customer customer2 = new Customer("Simo");
Librarian librarian = new Librarian("Librarian");
Librarian librarian2 = new Librarian("Falsy Librarian");

Comic comic = new Comic("ComicTitle", "ComicAuthor", "1997", "John Doe");
Novel novel = new Novel("NovelTitle", "NovelAuthor", "2002", "Drama");
TextBook textbook = new TextBook("TextBookTitle", "TextBookAuthor", "2020", 10);
ResearchPaper researchPaper = new ResearchPaper("RPTitle", "RPAuthor", "1879", 5);

library.AddUser(customer);
// library.AddUser(customer2);
library.AddUser(librarian);

librarian.AddBook(comic);
librarian.AddBook(novel);
librarian.AddBook(textbook);
librarian.AddBook(researchPaper);

customer.BorrowBook(comic.ISBN);
customer2.BorrowBook(comic.ISBN);
customer.ReturnBook(comic.ISBN);
customer2.BorrowBook(researchPaper.ISBN);
librarian.EditBook(comic.ISBN, newTitle: "NewComicTitle");

library.AddUser(customer2);
customer2.BorrowBook(comic.ISBN);
librarian.RemoveBook(comic.ISBN);
customer2.ReturnBook(comic.ISBN);

library.RemoveUser(customer);
textbook.PrintPages(1, 5);
researchPaper.PrintPages(1, 10);
comic.PrintInfo();

