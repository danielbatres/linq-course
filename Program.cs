LinqQueries queries = new LinqQueries();

// All collection
//PrintParameters(queries.AllCollection());

// Books after the year 2000
//PrintParameters(queries.BooksAfterYearTwoThousand());

// Books with more than 250 pages and title contains "In Action"
//PrintParameters(queries.BooksWithTwoConditions());

// All books has status
//Console.WriteLine($"All books has status? - {queries.AllBooksHasStatus()}");

// Is there a book that have been published in 2005
//Console.WriteLine($"Is there a book that has been published in 2005? - {queries.IsThereABookThat()}");

// Python books with contains
//PrintParameters(queries.PythonBooksWithContains());

// Books ordered by ascending title
//PrintParameters(queries.BooksOrderByAscendingTitle("Java"));

// Books of more than 450 pages sorted in descending order
//PrintParameters(queries.BooksWithMoreThan450PagesDescending());

// Three first books ordered by descending published date
//PrintParameters(queries.ThreeFirstBooksOrderByDate());

// Third and fourth book of more than 400 pages
//PrintParameters(queries.ThirdAndFourthBook());

// Three first books filtered with select 
//PrintParameters(queries.ThreeFirstBooks());

// Count the number of books that are between 200 and 500 pages long
//Console.WriteLine(queries.CountBooks());

// Minor publication date
//Console.WriteLine(queries.MinorPublicationDate());

// Larger page quantity 
//Console.WriteLine(queries.LargerPageQuantity());

// Book with fewer pages

//Book BookFewerPages = queries.BookWithFewerPages();

//Console.WriteLine($"{BookFewerPages.Title} - {BookFewerPages.PageCount}");

// Book with latest publication date

//Book BookLatest = queries.BookWithLatestPublicationDate();

//Console.WriteLine($"{BookLatest.Title} - {BookLatest.PublishedDate.ToShortDateString()}");

// Sum of book pages
//Console.WriteLine($"Total: {queries.SumOfBookPages()}");

// Concatenated Book titles
//Console.WriteLine(queries.ConcatenatedBookTitle());

// Average Characters title
Console.WriteLine(queries.AverageCharactersTitle());

void PrintParameters(IEnumerable<Book> booksCollection) {
  Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Title", "N.Pages", "PublishedDate");

  foreach (Book book in booksCollection) {
    Console.WriteLine("{0, -60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
  }
}
