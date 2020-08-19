using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    

    class SodaMachine
    {
        public List<Coin> register;
        public List<Can> inventory;
       


        public SodaMachine()
        {
            
            inventory = new List<Can>();
            StockColaInSodaMachine(15);
            StockOrangeSodaInSodaMachine(15);
            StockRootBeerInSodaMachine(15);

            register = new List<Coin>();
            StockPennyInMachine(50);
            StockNickleInMachine(20);
            StockDimeInMachine(10);
            StockQuarterInMachine(20);
        }
        //Coins
        public void StockPennyInMachine(int amount)
        {
            Penny penny = new Penny();
            for(int i = 0; i <= amount; i++)
            {
                register.Add(penny);
            }      
        }
        public void StockNickleInMachine(int amount)
        {
            Nickle nickle = new Nickle();
            for(int i = 0; i <= amount; i++)
            {
                register.Add(nickle);
            }
        }
        public void StockDimeInMachine(int amount)
        {
            Dime dime = new Dime();
            for(int i = 0; i <= amount; i++)
            {
                register.Add(dime);
            }
        }
        public void StockQuarterInMachine(int amount)
        {
            Quarter quarter = new Quarter();
            for(int i = 0; i <= amount; i++)
            {
                register.Add(quarter);
            }
        }

        //Soda
        public void StockColaInSodaMachine(int howMany)
        {
            Cola cola = new Cola();
            for(int i = 0; i <= howMany; i ++)
            {
                inventory.Add(cola);
            }
        }
        public void StockRootBeerInSodaMachine(int howMany)
        {
            RootBeer rootBeer = new RootBeer();
            for (int i = 0; i <= howMany; i++)
            {
                inventory.Add(rootBeer);
            }
        }
        public void StockOrangeSodaInSodaMachine(int howMany)
        {
            OrangeSoda orangeSoda = new OrangeSoda();
            for (int i = 0; i <= howMany; i++)
            {
                inventory.Add(orangeSoda);
            }
        }
    }
}
