using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int CopiesAvailable { get; set; }

        
    }

    public static class LINQ
    {
        public static List<Book> FindTroelsen(List<Book> books)
        {
            var bookByTroelsen = from book in books
                                 where book.Author == "Andrew Troelsen"
                                 select book;
            return bookByTroelsen.ToList();
        }
        public static List<Book> Ordonare(List<Book> books)
        {
            var orderByYear = books.OrderBy(book => book.Year);
            return orderByYear.ToList();
        }
        public static List<Book> Proectie(List<Book> books)
        {
            var copieDisponibila = from book in books
                                   where book.CopiesAvailable >= 1
                                   select book;
            return copieDisponibila.ToList();
        }
        public static int Agregare(List<Book> books)
        {
            var NrCopiiTotal = books
                .Select(a => a.CopiesAvailable)
                .Sum();
            return NrCopiiTotal;
        }
        public static List<string> Distinct(List<Book> books)
        {
            var uniqueAuthors = books
            .Select(b => b.Author)
            .Distinct()
            .ToList();
            return uniqueAuthors.ToList();
        }
        public static List<Book> Pagini(List<Book> books)
        {
            var ADouaPagina = books.Skip(2).Take(2);
            return ADouaPagina.ToList();
        }
    }

}
