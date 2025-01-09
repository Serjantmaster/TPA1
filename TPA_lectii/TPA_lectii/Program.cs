namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringObject = new PriorityQueue<string>();
            Console.WriteLine(stringObject.IsEmpty());
            stringObject.Enqueue("Dinosaur",14);
            stringObject.Enqueue("Delfin", 15);
            stringObject.Enqueue("Elefnat", 12);
            Console.WriteLine(stringObject.IsEmpty());
            Console.WriteLine(stringObject.Peek());
            Console.WriteLine(stringObject.Dequeue());
            Console.WriteLine(stringObject.Peek());
            Console.WriteLine();

            var intObject = new PriorityQueue<int>();
            Console.WriteLine(intObject.IsEmpty());
            intObject.Enqueue(1, -10);
            intObject.Enqueue(2, -2);
            intObject.Enqueue(3, 401);
            Console.WriteLine(intObject.Peek());
            Console.WriteLine(intObject.Dequeue());
            Console.WriteLine(intObject.Peek());
            Console.WriteLine();




        }
    }
}
