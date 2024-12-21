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
            int number = 0;
            foreach (var character in prefix)
            {
                number++;
            }
            cod = $"{prefix}{number}";
        }
        public void Afisare()
        {
            Console.WriteLine($"{cod}");
        }
    }
}
