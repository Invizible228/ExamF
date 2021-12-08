using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1pr31s18
{
    public class Programmer
    {
        public string surname;
        public int quantity;
        public int PLcount;
        public int q;
       public static int Quality(int q, int PLcount, int quantity)
        {
            q = quantity * PLcount;
            return q;
        }
    }
}
