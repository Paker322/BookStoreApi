using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookRepository _bookRepository;

    public BooksController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetBooks()
    {
        return Ok(await _bookRepository.GetAllBooksAsync());
    }

    // Implement other endpoints as needed, such as Get(id), Post(book), etc.
}
