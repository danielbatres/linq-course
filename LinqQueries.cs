public class LinqQueries {
  private List<Book> BooksCollection = new List<Book>();

  public LinqQueries() {
    using(StreamReader reader = new StreamReader("books.json")) {
      string json = reader.ReadToEnd();
      BooksCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { 
        PropertyNameCaseInsensitive = true 
      });
    }
  }

  public IEnumerable<Book> AllCollection() {
    return BooksCollection;
  }

  public IEnumerable<Book> BooksAfterYearTwoThousand() {
    return BooksCollection.Where(x => x.PublishedDate.Year > 2000);
  }
}