using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class Angajati
    {
        public string Name { get; set; }
        public int Vechime { get; set; }
        public readonly int SalariuMinim = 10000;
        public Angajati(string name, int vechime)
        {
            Name = name;
            Vechime = vechime;
        }

        public virtual void CalculeazaSalariu()
        {
            Console.WriteLine($"{SalariuMinim}");
        }
    }

    public class Managerul : Angajati
    {
        public int Expirience { get; set; }
        public Managerul(string name,int vechime,int expirience) : base (name, vechime)
        {
            Expirience = expirience;
        }
        public override void CalculeazaSalariu() 
        {
            Console.WriteLine($"Salariul managerului este {(SalariuMinim + SalariuMinim * 0.3) * Expirience}") ;
        }
    }
    public class Programator : Angajati
    {
        public List<string> Limbaje = new List<string>();
        public Programator(string name, int vechime,List<string> limbaje) : base(name, vechime)
        {
            Limbaje = limbaje;
        }
        public override void CalculeazaSalariu()
        {
            double salariu=0;
            foreach(string a in Limbaje)
            {
                if(a=="C#" || a =="c#")
                {
                    salariu += SalariuMinim * 4;
                }
                else
                {
                    salariu += SalariuMinim * 0.5;
                }
            }
            Console.WriteLine($"Salariul programatorului este {salariu}");
        }
    }
    public class Contabil : Angajati
    {
        public int Expirience { get; set; }
        public Contabil(string name, int vechime, int expirience) : base(name, vechime)
        {
            Expirience= expirience;
        }
        public override void CalculeazaSalariu()
        {
            Console.WriteLine($"Salariul contabile este {SalariuMinim + SalariuMinim * 0.2 * Expirience}"); 
        }
    }

}
