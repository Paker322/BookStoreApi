using MongoDB.Driver;

public class BookContext
{
    private readonly IMongoDatabase _database;

    public BookContext(IConfiguration config)
    {
        // Directly access the connection string and database name
        var connectionString = config["MongoDB:ConnectionString"];
        var databaseName = config["MongoDB:DatabaseName"];
        

        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<Book> Books => _database.GetCollection<Book>("book");
}
