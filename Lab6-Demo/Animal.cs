using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    public abstract class Animal
    {
        public string name;
        public int size;
        public abstract void Move();
        public abstract void Eat();

        public virtual void Drink()
        {
            Console.Write("Drink drink drink watter");
        }
    }
}
