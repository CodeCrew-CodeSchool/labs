using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    public abstract class Bird: Animal
    {
        public int wingSpan;
        public string color;
        public override void Move()
        {
            Console.Write("Fly");
        }

        public override void Eat()
        {
            Console.Write("Bird eats worm");
        }

        public override void Drink()
        {
            Console.Write("Sip sip through beak;")
        }
    }
}
