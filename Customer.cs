using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    
    class Customer
    {
        public Wallet wallet;
        Backpack backpack;
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();

        }

       
    }
}
