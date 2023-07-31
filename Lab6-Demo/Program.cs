namespace Lab6_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Bear bear = new Bear();
            Tiger tiger = new Tiger();
            Stork stork = new Stork("Blue");
            Console.WriteLine($"{stork.color}");
        }
    }
}