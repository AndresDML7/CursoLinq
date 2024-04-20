LinqQueries queries = new LinqQueries();

//PrintValues(queries.WholeCollection());

//PrintValues(queries.BooksAfter2000());

PrintValues(queries.BooksSecondCondition());

void PrintValues(IEnumerable<Book> bookList) 
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");

    foreach(var item in bookList)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
