﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public abstract class Coin
    {
        public string name;
        protected double value;
        public double Value
        {
            get
            {
                return value;
            }
        }
        public Coin()
        {  
        }

      

    }
}
