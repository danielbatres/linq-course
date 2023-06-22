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
    // Extension method
    //return BooksCollection.Where(x => x.PublishedDate.Year > 2000);

    // Query expression

    return from book in BooksCollection where book.PublishedDate.Year > 2000 select book;
  }

  public IEnumerable<Book> BooksWithTwoConditions() {
    // Extesion method
    //return BooksCollection.Where(x => x.PageCount > 250 && x.Title.Contains("in Action"));

    // Query expression

    return from book in BooksCollection where book.PageCount > 250 && book.Title.Contains("in Action") select book;
  }
}