using MongoDB.Driver;

public class BookRepository : IBookRepository
{
    private readonly BookContext _context;

    public BookRepository(BookContext context)
    {
        _context = context;
    }

    public async Task<List<Book>> GetAllBooksAsync()
    {
        return await _context.Books.Find(_ => true).ToListAsync();
    }

    // Add more methods to interact with the books collection, like GetBook(id), CreateBook(book), etc.
}
