using static System.Reflection.Metadata.BlobBuilder;

namespace C43_G02_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            // List<Book> books = new List<Book>
            // {
            // new Book("224466", "C#", new string[] { "Youssef Essam" }, new DateTime(2020, 9, 20), 45.99m),
            // new Book("113355", "Java", new string[] { "John Wayne" }, new DateTime(2004,8, 31), 60.79m),
            // };
            //
            // // user define 
            // BookFunctionDelegate titleDelegate = BookFunctions.GetTitle;
            // LibraryEngine.ProcessBooks(books, titleDelegate);
            //
            // // built in
            // Func<Book, string> authorsFunc = BookFunctions.GetAuthors;
            // LibraryEngine.ProcessBooksWithFunc(books, authorsFunc);
            //
            // //  Anonymous Method for GetISBN
            // BookFunctionDelegate isbnDelegate = delegate (Book b) { return b.ISBN; };
            // LibraryEngine.ProcessBooks(books, isbnDelegate);
            //
            // //  Lambda Expression for GetPublicationDate
            // Func<Book, string> pubDateLambda = b => b.PublicationDate.ToShortDateString();
            //   LibraryEngine.ProcessBooksWithFunc(books, pubDateLambda);

            #endregion 
        }
    }
}
