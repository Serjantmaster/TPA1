namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork work = new HumanWorker();
            work.Work();
            work = new RobotWorker();
            work.Work();

        }
    }
}
