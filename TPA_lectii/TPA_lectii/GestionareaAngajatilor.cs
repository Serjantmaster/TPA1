using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public abstract class AngajatiiTemplate
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Salary { get; set; }

        public abstract void CalculateAnnualSalary();
    }
    public class FullTimeEmployee : AngajatiiTemplate
    {
        public int Bonus=30000;

        public FullTimeEmployee(int slary)
        {
            Salary = slary;
        }

        public override void CalculateAnnualSalary()
        {
            Console.WriteLine($"Salariul tau(Full) este {Salary+Bonus}");
        }
    }

    public class PartTimeEmployee : AngajatiiTemplate
    {
        public int HouarlyRate=8;

        public PartTimeEmployee(int slary)
        {
            Salary = slary;
        }
        public override void CalculateAnnualSalary()
        {
            Console.WriteLine($"Salariul tau(Part) este {Salary + (HouarlyRate*2920)}"); ;
        }
    }
}
