using System;


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
        Console.WriteLine(Sum);
    }
    public void Alimentare(int sum)
    {
        Sum += sum;
    }

    public void Exstragere(int sum)
    {
        if (Sum - sum >= 0)
        {
            Sum -= sum;
        }
        else
        {
            Console.WriteLine("Insuficent funds");
        }
    }
}
