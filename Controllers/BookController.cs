using Microsoft.AspNetCore.Mvc;
using Summaries.Data;

namespace Summaries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService _service;
        public BookController(IBookService service)
        {
          _service = service;
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
          _service.AddBook(book);
          return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
          var allBooks = _service.GetAllBooks();
          return Ok(allBooks);
        }

        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {
          _service.UpdateBook(id, book);
          return Ok("Updated");
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteBook(int id)
        {
          _service.DeleteBook(id);
         return Ok("Deleted");
        }

        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookId(int id)
        {
          var book = _service.GetBookId(id);
          return Ok(book);
        }
    }
}