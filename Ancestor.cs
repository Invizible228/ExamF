using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1pr31s18
{
    public class Ancestor : Programmer
    {
        public int p;
        public int qp;
        public static int Calculating(int qp, int p, int q, int PLcount, int quantity)
        {
            q = Quality(q, PLcount, quantity);
            qp = q * p;
            return qp;
        }
    }
}
