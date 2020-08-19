using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public class Nickle : Coin
    {
        private double value;

        public double Value
        {
            get
            {
                return value;
            }
        }
        public Nickle()
        {
            name = "nickle";
            value = 0.05;
        }
    }
}
