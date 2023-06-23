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

  public bool AllBooksHasStatus() {
    return BooksCollection.All(x => x.Status != string.Empty);
  }

  public bool IsThereABookThat() {
    return BooksCollection.Any(x => x.PublishedDate.Year == 2005);
  }

  public IEnumerable<Book> PythonBooksWithContains() {
    return BooksCollection.Where(x => x.Categories.Contains("Python"));
  }

  public IEnumerable<Book> BooksOrderByAscendingTitle(string category) {
    return BooksCollection.Where(x => x.Categories.Contains(category)).OrderBy(x => x.Title);
  }

  public IEnumerable<Book> BooksWithMoreThan450PagesDescending() {
    return BooksCollection.Where(x => x.PageCount > 450).OrderByDescending(x => x.PageCount);
  }

  public IEnumerable<Book> ThreeFirstBooksOrderByDate() {
    return BooksCollection
    .Where(x => x.Categories.Contains("Java"))
    .OrderBy(x => x.PublishedDate)
    .TakeLast(3);
  }

  public IEnumerable<Book> ThirdAndFourthBook() {
     return BooksCollection.Where(x => x.PageCount > 400)
     .Take(4)
     .Skip(2);
  }
}