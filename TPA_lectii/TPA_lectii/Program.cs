namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> limbaje = new List<string> { "C#", "python","c++","limbaj"};
            
            List<Angajati> angajati = new List<Angajati>
            {
                 new Managerul("Daniel",2,5),
                 new Programator("Vasile",2,limbaje),
                 new Contabil ("Mihai",2,5)
            };
            foreach(Angajati a in angajati)
            {
                a.CalculeazaSalariu();
            }
        }
    }
}
