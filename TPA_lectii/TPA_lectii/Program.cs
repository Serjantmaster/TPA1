namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
            new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet", Year = 2019, CopiesAvailable = 5 },
            new Book { Id = 2, Title = "Pro C# 7", Author = "Andrew Troelsen", Year = 2018, CopiesAvailable = 2 },
            new Book { Id = 3, Title = "C# 6.0 and the .NET 4.6 Framework", Author = "Andrew Troelsen", Year = 2015, CopiesAvailable = 0 },
            new Book { Id = 4, Title = "Learning C# by Developing Games", Author = "Harrison Ferrone", Year = 2020, CopiesAvailable = 4 },
            new Book { Id = 5, Title = "CLR via C#", Author = "Jeffrey Richter", Year = 2012, CopiesAvailable = 1 }
            };
            var first = LINQ.FindTroelsen(books);
            foreach (var book in first)
                Console.WriteLine(book.Id);
            Console.WriteLine();

            var second = LINQ.Ordonare(books);
            foreach (var book in second)
                Console.WriteLine(book.Id);
            Console.WriteLine();

            var third = LINQ.Proectie(books);
            foreach (var book in third)
                Console.WriteLine(book.Id);
            Console.WriteLine();

            
            Console.WriteLine(LINQ.Agregare(books));
            Console.WriteLine();

            var forth = LINQ.Proectie(books);
            foreach (var book in forth)
                Console.WriteLine(book.Id);
            Console.WriteLine();

            var fifth = LINQ.Pagini(books);
            foreach (var book in fifth)
                Console.WriteLine(book.Id);
            Console.WriteLine();


        }
    }
}
