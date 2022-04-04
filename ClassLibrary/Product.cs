using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Product
    {
        public string Name { get; set; }
        public static int No { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

    }
}
