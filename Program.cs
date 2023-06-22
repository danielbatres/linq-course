LinqQueries queries = new LinqQueries();

PrintParameters(queries.AllCollection());

void PrintParameters(IEnumerable<Book> booksCollection) {
  Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Title", "N.Pages", "PublishedDate");

  foreach (Book book in booksCollection) {
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
  }
}
