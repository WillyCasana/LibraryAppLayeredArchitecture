
using LibraryApp.BLL;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Models;

namespace LibraryApp.UI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController: ControllerBase
    {
        private readonly BookService _service;

        public BooksController(){

            _service= new BookService();
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_service.GetBooks());
        }

        public IActionResult AddBook(Book book)
        {
            _service.CreateBook(book);
            return Ok();
        }
        
    }
}