public interface IBookRepository
{
    Task<List<Book>> GetAllBooksAsync();
    // Declare other method signatures that you want to implement, like:
    // Task<Book> GetBookAsync(string id);
    // Task CreateBookAsync(Book book);
    // Task UpdateBookAsync(string id, Book book);
    // Task DeleteBookAsync(string id);
}
