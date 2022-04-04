using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Notebook:Product
    {
        public Notebook()
        {
            No++;
        }
        public static int No { get; set; } 
        public int RAM { get; set; }
        public int Storage { get; set; }

    }
}
