namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.Eat();
            animal.MakeSound();
            animal=new Cat();
            animal.Eat();
            animal.MakeSound();
            IRunnable run;
            run = new Dog();
            run.Run();
            run = new Cat();
            run.Run();

            Console.WriteLine();
            Manager manager = new Manager("Radiologie", "Andrei");
            manager.AfisareDetalii();

            Console.WriteLine();
            Mamifer mamifer = new Mamifer("Alb","Caine");
            Pasare pasare = new Pasare("Altitudine joasa", "pasare");
            Papagal papagal = new Papagal(345,"Altitudine medie","papagal");
            mamifer.AfisareDetalii();
            pasare.AfisareDetalii();
            papagal.AfisareDetalii();
        }
    }
}
