using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    class Wallet
    {
        public List<Coin> coins;
        Card card;
        public Wallet()
        {
            coins = new List<Coin>();
            AddTotalCoinToWallet();
            
            card = new Card();

        }

        public void AddTotalCoinToWallet()
        {
            AddPennyToWallet(25);
            AddNickleToWallet(15);
            AddDimeToWallet(10);
            AddQuarterToWallet(12);
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
        
        public void AddDimeToWallet(int amount)
        {
            Dime dime = new Dime();
            for (int i = 0; i <= amount; i++)
            {
                coins.Add(dime);
            }
        }

        public void AddQuarterToWallet(int amount)
        {
            Quarter quarter = new Quarter();
            for (int i = 0; i <= amount; i++)
            {
                coins.Add(quarter);
            }
        }

    }
}
