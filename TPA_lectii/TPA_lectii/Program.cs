namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonat forTest = new Abonat();
            EventManager eventManager = new EventManager();
            eventManager.Add(forTest.Metoda1);
            eventManager.Add(forTest.Metoda2);
            eventManager.CreateNewEvent();
            eventManager.EventActualization();

        }

        public class Abonat
        {
            public void Metoda1(string mesaj)
            {
                Console.WriteLine(mesaj);
            }
            public void Metoda2(string mesaj)
            {
                Console.WriteLine($"Alt mesaj : {mesaj}");
            }
        }
    }
}
