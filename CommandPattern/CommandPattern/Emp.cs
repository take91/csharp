﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Emp
    {
        public string Ename { get; set; }
        public string job { get; set; }

        public override string ToString()
        {
            return Ename + ", " + job; 
        }
    }
}
