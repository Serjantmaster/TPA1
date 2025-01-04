using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class Angajatul
    {
        public string Name { get; set; }
        public Angajatul(string name) 
        {
            Name = name;
        }
        public void AfisareDetalii()
        {
            Console.WriteLine($"Angajatul {Name}");
        }
    }
    public class Manager : Angajatul
    {
        public string Departament;
        public Manager(string Departmanet, string name) : base(name)
        {
            Departament = Departmanet;
        }

    }
}
