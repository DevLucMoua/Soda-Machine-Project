using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class Wallet
    {
        List<Coin> coins;
        Card card;
        public Wallet()
        {
            coins = new List<Coin>();
            
            card = new Card();

        }

        public void AddTotaCoinToWallet()
        {
            
        }

        public void AddPennyToWallet()
        {
            Penny penny = new Penny();
            coins.Add(penny);

        }
    }
}
