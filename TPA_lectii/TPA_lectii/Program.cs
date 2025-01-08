namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringObject = new PriorityQueue<string>();
            stringObject.IsEmpty();
            stringObject.Enqueue("Dinosaur",14);
            stringObject.Enqueue("Delfin", 15);
            stringObject.Enqueue("Elefnat", 12);
            stringObject.IsEmpty();
            Console.WriteLine(stringObject.Peek());
            stringObject.Dequeue();
            Console.WriteLine(stringObject.Peek());
            Console.WriteLine();

            var intObject = new PriorityQueue<int>();
            intObject.IsEmpty();
            intObject.Enqueue(1, -10);
            intObject.Enqueue(2, -2);
            intObject.Enqueue(3, 401);
            Console.WriteLine(intObject.Peek());
            intObject.Dequeue();
            Console.WriteLine(intObject.Peek());
            Console.WriteLine();




        }
    }
}
