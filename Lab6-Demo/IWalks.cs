using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    public interface IWalks
    {
        public int legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }
}
