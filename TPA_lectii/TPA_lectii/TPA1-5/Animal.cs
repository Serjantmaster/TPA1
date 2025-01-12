using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TPA_lectii
{
    public class Animalul
    {
        public string Name { get; set; }
        
        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"Numele animalului este {Name}");
        }
    }
    public class Mamifer : Animalul 
    {
        public string CuloareaBlanii { get; set; }

        public Mamifer( string culoareaBlanii, string name)
        {
            CuloareaBlanii = culoareaBlanii;
            Name = name;
        }
        public override void AfisareDetalii()
        {
            Console.WriteLine($"Numele mamiferului este {Name}, Are blana de culoare {CuloareaBlanii}");
        }
    }

    public class Pasare : Animalul 
    {
        public string TipZbor { get; set; }

        public Pasare(string tipZbor, string name)
        {
            TipZbor = tipZbor;
            Name = name;
        }
        public override void AfisareDetalii()
        {
            Console.WriteLine($"Numele pasarii este {Name}, tipul zborului este {TipZbor}");
        }
    }

    public class Papagal : Pasare
    {
        public int Vocabular { get; set; }
        public Papagal (int vocabular,string tipZbor, string name) : base(tipZbor, name)
        {
            Vocabular = vocabular;
        }

        public override void AfisareDetalii()
        {
            Console.WriteLine($"Numele papagalului este {Name}, tipul zborului este {TipZbor}, vocabularul lui are {Vocabular} de cuvinte");
        }
    }

}
