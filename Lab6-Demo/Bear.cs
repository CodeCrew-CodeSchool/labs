﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Demo
{
    internal class Bear: Mammal, IWalks
    {
        public int legs { get; set; }
        public string furColor;
    }
}
