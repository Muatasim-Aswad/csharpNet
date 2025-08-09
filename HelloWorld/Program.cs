// See https://aka.ms/new-console-template for more information
using HelloWorld.previous.library;

var library = new Library();
library.AddBook(new Book("1984", "George Orwell"));
library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
var foundBook = library.FindBook("1984");
foundBook.GetInfo();

