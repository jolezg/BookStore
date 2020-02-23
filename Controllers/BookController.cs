using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApi.Domain.Models;
using BookStoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookStoreApi.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class BookController : ControllerBase {

        private readonly IBookService _bookService;

        public BookController (IBookService bookService) {

            _bookService = bookService;
        }

        [HttpPost]
        public async Task<IActionResult> Post (Book book) {
            var book1 = await _bookService.CreateBook (book);

            return Ok (book1);
        }

        [HttpGet]
        public async Task<IActionResult> GetBookAsync (int id) {
            var book1 = await _bookService.GetBookById (id);

            if (book1 == null)
                return NoContent ();
            return Ok (book1);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookAsync (int id) {
            var deleted = await _bookService.DeleteBook (id);
            if (deleted)
                return NoContent ();

            return BadRequest ();

        }
    }
}