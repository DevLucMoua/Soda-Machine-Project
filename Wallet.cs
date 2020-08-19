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

        public void AddPennyToWallet(int amount)
        {
            Penny penny = new Penny();
            for (int i = 0; i <= amount; i++)
            {
                coins.Add(penny);
            }
        }

        public void AddNickleToWallet(int amount)
        {
            Nickle nickle = new Nickle();
            for (int i = 0; i <= amount; i++)
            {
                coins.Add(nickle);
            }
        }
        
        public void AddDimeToWallet()
        {
            Dime dime = new Dime();
            
        }
    }
}
