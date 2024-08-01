namespace Advanced03
{
    internal class Program
    {
        public delegate string GetTitledDlegate(Book book);

        public delegate string GetAuthorsDelegate(Book book);

        public delegate decimal GetPriceDelegate(Book book);

        static void Main(string[] args)
        {
            #region Part 01 :
            // a
            string[] authors = { "mohab", "mohamed", "belkan" };

            Book book = new Book("B25H", "C#", authors, DateTime.Now, 50.5m);

            GetTitledDlegate getTitledDlegate = BookFunctions.GetTitle;

            GetAuthorsDelegate getAuthorsDelegate = BookFunctions.GetAuthors;

            GetPriceDelegate getPriceDelegate = BookFunctions.GetPrice;

            Console.WriteLine(getTitledDlegate(book)); // C#
            Console.WriteLine(getAuthorsDelegate(book)); // mohab, mohamed, belkan
            Console.WriteLine(getPriceDelegate(book)); // 50.5


            // b
            Func<Book, string> func01 = BookFunctions.GetTitle;
            Func<Book, string> func02 = BookFunctions.GetAuthors;
            Func<Book, decimal> func03 = BookFunctions.GetPrice;

            // c (Anonymous Method)
            Func<Book, string> funcISBN = delegate (Book book)
            {
                return book.ISBN;
            };
            Console.WriteLine(funcISBN(book)); // B25H

            // d (Lambda Expression)
            Func<Book, DateTime> funcPublicationDate = (Book Book) => book.PublicationDate;
            Console.WriteLine(funcPublicationDate(book)); // 8/1/2024 5:40:36 PM 
            #endregion


        }
    }
}
