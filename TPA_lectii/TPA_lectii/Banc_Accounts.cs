using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
        public class Accaunts
        {
            public string Name;
            public int Number;
            public int Sum;
            public string Pin;
            public int Date;

            public Accaunts(string name, int number, int sum, string pin)
            {
                Name = name;
                Number = number;
                Sum = sum;
                Pin = pin;
                Date = DateTime.UtcNow.Year;
            }
            public void Sold()
            {
                Console.WriteLine($"In acaunt sunt {Sum} bani");
            }
            public void Alimentare(int sum)
            {
                Sum += sum;
                Console.WriteLine("Alimentare efectuata cu succes");
            }

            public void Exstragere(int sum)
            {
                if (Sum - sum >= 0)
                {
                    Sum -= sum;
                    Console.WriteLine("Extragere efectuata cu succes");
                }
                else
                {
                    Console.WriteLine("Insuficent funds");
                }
            }
        }
}
