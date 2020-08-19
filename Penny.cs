using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Penny : Coin
    {
        private double value;
        public double Value
        {
            get
            {
                return value;
            }
        }
        public Penny()
        {
            name = "penny";
            value = 0.01;
        }
    }
}
