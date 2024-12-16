namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angajat angajat = new Angajat("Vasile","c",421);
            angajat.Afisare();
            Accaunts acaunt = new Accaunts("Andrei",142531,10,"afwafregw");
            acaunt.Sold();
            acaunt.Alimentare(3);
            acaunt.Sold();        
            acaunt.Exstragere(12);
            acaunt.Sold();
            acaunt.Exstragere(4);
            acaunt.Sold();
        }
    }
}
