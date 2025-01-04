using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class Carte
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public int NumberOfPages { get; set; }

        public Carte(string title, string author, int publicationYear, int numberOfPages)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            NumberOfPages = numberOfPages;
        }
        public void Afisare()
        {
            Console.WriteLine($"Cartea {Title} scrisa de {Author} a fost publicata in anul {PublicationYear}, avand {NumberOfPages} de pagini");
        }
    }
}
