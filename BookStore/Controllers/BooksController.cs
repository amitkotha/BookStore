using BookStore.Services;
using BookStore.Services.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookServices;
        private readonly ILogger<BooksController> _logger;


        public BooksController(IBookService bookServices,ILogger<BooksController> logger)
        {
            _bookServices = bookServices;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            return Ok(await _bookServices.GetBookAsync());
        }
        [HttpPost]
        public async Task<IActionResult> InsertBookAsync(Book book)
        {
           await _bookServices.AddBookAsync(book);
            return Ok(book);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookAsync(string id)
        {
            return Ok(await _bookServices.GetBookAsync(id));
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookAsync(string id)
        {
            await _bookServices.DeleteBookAsync(id);
            return NoContent();
        }


    }
}
