using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    public abstract class Mammal: Animal
    {
        public int clawSize;
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
