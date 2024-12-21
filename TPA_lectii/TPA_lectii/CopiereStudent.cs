using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class Student
    {
        public string Name;
        public int Years;
        public string Specialiti;

        public Student(string name,int years,string specialiti) 
        {
            Name = name;
            Years = years;
            Specialiti = specialiti;
        }
        public Student(Student obiect)
        {
            Name = obiect.Name;
            Years = obiect.Years;
            Specialiti = obiect.Specialiti;
        }
        public void Afisare()
        {
            Console.WriteLine($"Studentul {Name} cu varsta {Years} are specialitatea de {Specialiti}");
        }
    }
}
