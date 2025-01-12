using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TPA_lectii
{
        public class Accaunts
        {
            public string Name;
            public int Number;
            public int Sum;
            public string Pin;
            public int Date;
            public List<string> TransactionHistory = new List<string>();   
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
            public void History()
            {
                Console.WriteLine("History of acaunt transactions:");
                foreach (string transaction in TransactionHistory)
                {
                Console.WriteLine(transaction);
                }
            }
            public void Alimentare(int sum)
            {
                Sum += sum;
                Console.WriteLine("Alimentare efectuata cu succes");
            TransactionHistory.Add($"+{sum}");
            }

            public void Exstragere(int sum)
            {
                if (Sum - sum >= 0)
                {
                    Sum -= sum;
                    Console.WriteLine("Extragere efectuata cu succes");
                    TransactionHistory.Add($"-{sum}");
                }
                else
                {
                    Console.WriteLine("Insuficent funds");
                }
            }
        }
}
