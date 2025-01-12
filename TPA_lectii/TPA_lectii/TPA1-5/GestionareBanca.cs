using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; set;}
        public double Balance { get; set; }
        public BankAccount(double balance, string acauntnumber)
        {
            Balance = balance;
            AccountNumber = acauntnumber;
        }
        public void Deposit(double amount) 
        { 
            if(amount>0)
            {
                Balance += amount;
                Console.WriteLine("Suma a fost depozitata");
            }
            else
            {
                Console.WriteLine("Suma data este invalida");
            }
        }
        public void Withdraw(double amount) 
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Suma a fost exstrasa");
            }
            else
            {
                Console.WriteLine("Insuficiente fonduri");
            }
        }

    }
    public class SavingsAccount : BankAccount 
    {
        public double Interest { get; set; }
        public SavingsAccount(double interest,double balance, string acauntnumber) : base(balance, acauntnumber)
        {
            Interest = interest;
        }
        public new void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Balance += (Balance*Interest)/100; 
                Console.WriteLine("Suma a fost depozitata");
            }
            else
            {
                Console.WriteLine("Suma data este invalida");
            }
        }

    }
    public class CheckingAccount : BankAccount
    {
        public double OverdraftLimit {  get; set; }
        public CheckingAccount(double overdtraftLimit,double balance, string acauntnumber) : base(balance, acauntnumber)
        {
            OverdraftLimit = overdtraftLimit;
        }
        public new void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Suma a fost exstrasa");
            }
            if (Balance+OverdraftLimit >= amount)
            {
                Balance = 0;
                Console.WriteLine("Suma a fost exstrasa");
            }
            else
            {
                Console.WriteLine("Insuficiente fonduri");
            }
        }
    }
}
