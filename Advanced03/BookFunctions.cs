using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03
{
    internal static class BookFunctions
    {
        public static string GetTitle(Book book)
        {

            return book.Title;
        }

        public static string GetAuthors(Book book)
        {
            string authors = "";
            for (int i = 0; i < book.Authors.Length; i++)
            {
                authors= string.Join(", ", book.Authors);
            }

            return authors;


        }

        public static decimal GetPrice(Book book)
        {

            return book.Price;
        }
    }
}
