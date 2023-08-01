using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    public interface ISwims
    {
        public bool inWater { get; set; }
        public void Swim()
        {
            Console.WriteLine("Just keep swimming..");
        }
    }
}
