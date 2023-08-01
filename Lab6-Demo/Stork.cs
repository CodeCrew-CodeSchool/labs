using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    public class Stork: Bird, IWalks
    {
        public int beakSize;
        public int legs { get; set; }

        public Stork(string feathercolor)
        {
            color = feathercolor;
        }

        public void fly()
        {
            Console.Write("Kawkaw");
        }
    }
}
