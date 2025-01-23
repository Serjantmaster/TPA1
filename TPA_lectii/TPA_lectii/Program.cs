namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ASync test = new ASync();
            test.Apelare().Wait();

        }
    }
}
