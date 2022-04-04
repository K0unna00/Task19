using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Phone:Product
    {
        public Phone()
        {
            No++;
        }
        public byte SIMcount { get; set; }
        public static int No { get; set; } 

    }
}
