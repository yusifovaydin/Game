using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Qurashdir
    {
        public static int Witdh { get; set; }   
        public static int Height { get; set; }
        public static string directions;

        public Qurashdir()
        {
            Witdh = 16;
            Height = 16;
            directions = "left";
        }
    }
}
