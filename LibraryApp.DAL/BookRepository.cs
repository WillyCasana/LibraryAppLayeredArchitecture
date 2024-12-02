using  LibraryApp.Models;

namespace LibraryApp.DAL
{
    public class BookRepository
    {
        private List<Book> books= new List<Book>();

        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}