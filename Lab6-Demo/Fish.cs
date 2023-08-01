
namespace Lab6_Demo
{
    public abstract class Fish: Animal
    {
        public int gillSize;
        public string stripeColor;
        public override void Move()
        {
            Console.Write("Walk");
        }

        public override void Eat()
        {
            Console.Write("Mammal eats meat");
        }
    }
}