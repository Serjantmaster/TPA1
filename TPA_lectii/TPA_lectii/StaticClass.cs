using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{

    public class Helper
    {
        private string cod;
        public Helper(string prefix)
        {
            var number = new Random();
            cod = $"{prefix}{number.Next(100)}";
        }
        public void Afisare()
        {
            Console.WriteLine($"{cod}");
        }
    }
}
