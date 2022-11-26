using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplicationCoreWebApi.Business_Layer.Interfaces;
using WebApplicationCoreWebApi.Models.RequestModels;

namespace WebApplicationCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksHandlingController : ControllerBase
    {
        private readonly IBooks_BAL _books_BAL;
        private readonly ILogger<BooksHandlingController> _logger;

        public BooksHandlingController(ILogger<BooksHandlingController> logger, IBooks_BAL books_BAL)
        {
            _logger = logger;
            _books_BAL = books_BAL;
        }
        /// <summary>
        /// Save new book in DB.
        /// </summary>
        /// <returns>HttpStatusCode.Ok</returns>
        /// <exception cref="HttpStatusCode.InternalServerError"></exception>


        [HttpPost("saveBooks")]
        public async Task<IActionResult> Post(BookModel books)
        {
            try
            {
                var res = await _books_BAL.Post(books);
                if (res > 0)
                    return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(MyLogEvents.InsertItem, ex.StackTrace);
            }
            return StatusCode((int)HttpStatusCode.InternalServerError);

        }
        /// <summary>
        /// Gets the list of all Books.
        /// </summary>

        [HttpGet("getBooks")]
        public async Task<IActionResult> Get()
        {
            try
            {

                var results = await _books_BAL.Get();
                if (results.Count > 0)
                    return Ok(results);

            }
            catch (Exception ex)
            {
                _logger.LogInformation(MyLogEvents.GetItem, "Get Books");
            }
            return NotFound();

        }
        /// <summary>
        /// Gets the list of all Books.
        /// </summary>

        [HttpGet("getBookById")]
        public async Task<IActionResult> GetById(Guid guid)
        {
            try
            {

                var result = await _books_BAL.GetById(guid);
                if (result!=null)
                    return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogInformation(MyLogEvents.GetItem, "Get Book By Id");
            }
            return NotFound();

        }
    }
}