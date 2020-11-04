using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animals
    {
        public bool IsColdBlooded { get; set; }
        public bool HasLegs { get; set; }
        public bool HasScales { get; set; }
        public bool EatMeat { get; set; }
    }
}
