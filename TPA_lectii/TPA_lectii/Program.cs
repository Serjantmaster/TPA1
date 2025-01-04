namespace TPA_lectii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new GenericClassMathOperations<double>();
            double value =a.Add(2, 3);
            Console.WriteLine(value);
             value = a.Subtract(2, 3);
            Console.WriteLine(value);
             value = a.Multiply(2, 3);
            Console.WriteLine(value);
             value = a.Divide(2.0, 3);
            Console.WriteLine(value);

        }
    }
}
