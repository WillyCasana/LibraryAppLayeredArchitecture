
using LibraryApp.DAL;
using LibraryApp.Models;

namespace LibraryApp.BLL
{
    public class BookService
    {
        private readonly BookRepository _repository;

        public BookService()
        {
            _repository= new BookRepository();
        }

        public IEnumerable<Book> GetBooks()
        {
            return _repository.GetAllBooks();
        }

        public void CreateBook(Book book)
        {
            _repository.AddBook(book);
        }
    }
}