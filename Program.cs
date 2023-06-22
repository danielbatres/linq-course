LinqQueries queries = new LinqQueries();

// All collection
//PrintParameters(queries.AllCollection());

// Books after the year 2000
//PrintParameters(queries.BooksAfterYearTwoThousand());

// Books with more than 250 pages and title contains "In Action"
PrintParameters(queries.BooksWithTwoConditions());

void PrintParameters(IEnumerable<Book> booksCollection) {
  Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Title", "N.Pages", "PublishedDate");

  foreach (Book book in booksCollection) {
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
  }
}
