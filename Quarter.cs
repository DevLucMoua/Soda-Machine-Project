using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Quarter : Coin
    {
        private double value;

        public double Value
        {
            get
            {
                return value;
            }
        }
        public Quarter()
        {
            name = "quarter";
            value = 0.25;
        }
    }
}
