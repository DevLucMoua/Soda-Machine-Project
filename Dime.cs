using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Dime : Coin
    {
        private double value;

        public double Value
        {
            get
            {
                return value;
            }
        }
        public Dime()
        {
            name = "dime";
            value = 0.10;
        }
    }
}
