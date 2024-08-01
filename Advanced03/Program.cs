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
            //string[] authors = { "mohab", "mohamed", "belkan" };

            //Book book = new Book("B25H", "C#", authors, DateTime.Now, 50.5m);

            //GetTitledDlegate getTitledDlegate = BookFunctions.GetTitle;

            //GetAuthorsDelegate getAuthorsDelegate = BookFunctions.GetAuthors;

            //GetPriceDelegate getPriceDelegate = BookFunctions.GetPrice;

            //Console.WriteLine(getTitledDlegate(book)); // C#
            //Console.WriteLine(getAuthorsDelegate(book)); // mohab, mohamed, belkan
            //Console.WriteLine(getPriceDelegate(book)); // 50.5


            //// b
            //Func<Book, string> func01 = BookFunctions.GetTitle;
            //Func<Book, string> func02 = BookFunctions.GetAuthors;
            //Func<Book, decimal> func03 = BookFunctions.GetPrice;

            //// c (Anonymous Method)
            //Func<Book, string> funcISBN = delegate (Book book)
            //{
            //    return book.ISBN;
            //};
            //Console.WriteLine(funcISBN(book)); // B25H

            //// d (Lambda Expression)
            //Func<Book, DateTime> funcPublicationDate = (Book Book) => book.PublicationDate;
            //Console.WriteLine(funcPublicationDate(book)); // 8/1/2024 5:40:36 PM 
            #endregion

            #region Part 02 :

            List<int> list = new List<int> { 1,2,3,4,5,6,4,8,95,4,2,5,7,5,1,6,4,2,4,5,24,5,2,4,5,6,2,45};

            #region Predefined 
            Console.WriteLine(list.Exists(N => N == 2)); // True

            Console.WriteLine(list.Find(N => N == 2)); // 2

            List<int> x = list.FindAll(N => N == 2);
            foreach (var item in x)
            {
                Console.Write(item + " "); // 2 2 2 2 2
            }
            Console.WriteLine();

            Console.WriteLine(list.FindIndex(N => N == 4)); // 3

            Console.WriteLine(list.FindLast(N => N == 4)); // 4

            Console.WriteLine(list.FindLastIndex(N => N == 95)); // 8;

            list.ForEach(N => { N += 10; });

            Console.WriteLine(list.TrueForAll(N => N > 0)); // True 
            #endregion

            #region User-Defined Methods
            MyList<int> myList = new MyList<int>();
            myList.Exists((N => N == 2));
            myList.Find(N => N == 2);
            myList.FindIndex(N => N == 4);
            List<int> x2 = myList.FindAll(N => N == 2);
            myList.FindLast(N => N == 4);
            myList.FindLastIndex(N => N == 95);
            myList.Foreach(N => { N += 10; });
            myList.TrueForAll(N => N > 0);
            #endregion




            #endregion
        }
    }
}
