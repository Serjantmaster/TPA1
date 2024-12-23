namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var codeOne = new Helper("1");
            codeOne.Afisare();
            var codeTwo = new Helper("521apkmgs250-41");
            codeTwo.Afisare();

            var book = new Carte("O carte","Alexandru",2008,159);
            book.Afisare();

            var studentOne = new Student("Vaslie", 28, "Cibernetica");
            var studentTwo = new Student(studentOne);
            studentTwo.Afisare();
            studentOne.Name = "Mihai";
            studentOne.Afisare();
            Console.ReadLine();
        }
    }
}
