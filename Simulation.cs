using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    
    class Simulation
    {
        SodaMachine sodaMachine;
        Customer customer;
        List<Coin> temporaryRegister;

        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
            temporaryRegister = new List<Coin>();
        }

       
        public void BeginPurchase()
        {
            UserMenu.DisplayIntro();
            SelectSoda();
        }

        public void InsertCoinsForPurchase()
        {
            while (UserMenu.DoYouWantMoreCoins())
            {
                Coin coin = UserMenu.ChooseCoinsForPayment();
                
                temporaryRegister.Add(coin);
            }
            string coinSelected = UserMenu.DisplayCoinSelection();
            //customer.wallet.coins.Remove();


        }

        public void SelectSoda()
        {
            UserMenu.DisplayMenuAndPrices();
            string sodaSelected = UserMenu.EnterSelection();
            bool machineHasSoda = sodaMachine.CheckInventory(sodaSelected);
            if(machineHasSoda)
            {
                InsertCoinsForPurchase();
                CheckAmountInTemporaryRegister();
                if(temporaryRegister. >= canCost)
                
                
                
                //adds coins to the temp register
                //need to see if the coins that are inside the temp register are enough for the soda selected
                //^^^^^for this we need to compare cost of soda found to money in temp register 
                //if it's enough dispense soda
                //if more than and enough change in the machine, give change and dispense soda.
                //if not enough, start select soda again

                sodaMachine.DispenseSoda(sodaSelected);
            }
            else
            {
                SelectSoda();
            }
            

        }

        public double CheckAmountInTemporaryRegister()
        {
            double coinValue = 0;
            foreach (var coin in temporaryRegister)
            {
                if (coin.Value == coinValue)
                {
                   coinValue = coin.Value;

                }
            }
            return coinValue;
        }
    }
}
