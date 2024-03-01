using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Book Title")]
    public string BookTitle { get; set; }

    [BsonElement("Author Name")]
    public string AuthorName { get; set; }

    [BsonElement("Publisher")]
    public string Publisher { get; set; }

    [BsonElement("Book Image URL")]
    public string BookImageUrl { get; set; }

    [BsonElement("Genres")]
    public List<string> Genres { get; set; }

    [BsonElement("Price")]
    public decimal Price { get; set; }

    [BsonElement("Rating Text")]
    public string? RatingText { get; set; }

    [BsonElement("Rating Number")]
    public int? RatingNumber { get; set; }

    [BsonElement("Description")]
    public string Description { get; set; }
}
