using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soda_Machine
{
    public static class UserMenu
    {
        public static void DisplayIntro()
        {
            Console.WriteLine("Welcome to Luc's One Stop Soda Shop!");
        }

        public static void DisplayMenuAndPrices()
        {
            Console.WriteLine("Orange Soda costs $0.06");
            Console.WriteLine("Root Beer costs $0.035");
            Console.WriteLine("Cola costs $0.60");
        }

        public static string DisplayCoinSelection()
        {
            Console.WriteLine("Enter payment.");
            Console.WriteLine("Type 'penny' to insert penny.");
            Console.WriteLine("Type 'nickle' to insert nickle.");
            Console.WriteLine("Type 'dime' to insert dime.");
            Console.WriteLine("Type 'quarter' to insert quarter.");
            string coinSelected = Console.ReadLine();
            return coinSelected;
            
        }
        public static bool DoYouWantMoreCoins()
        {
            Console.WriteLine("Do you want more coins. Enter yes if you do.");
            string response = Console.ReadLine();
            if (response == "yes")
                return true;
            else
            {
                return false;
            }
            
        }
        public static Coin ChooseCoinsForPayment()
        {
            Console.WriteLine("Enter coins for payment.");
            Console.WriteLine("Type 'penny', 'nickle', 'dime', 'quarter' to enter payment");
            string input = Console.ReadLine();
            Coin coin = null;
            switch (input)
            {
                case "penny":
                    coin = new Penny();
                    break;
                case "nickle":
                    coin = new Nickle();
                    break;
                case "Dime":
                    coin = new Dime();
                    break;
                case "quarter":
                    coin = new Quarter();
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    ChooseCoinsForPayment();
                    break;

            }
            return coin;
        }
        public static string EnterSelection()
        {
            Console.WriteLine("Type cola, orange soda, or root beer.");
            string sodaSelected = Console.ReadLine();
            return sodaSelected;
        }

        public static void NoInventoryPrompt()
        {
            Console.WriteLine("That selection is not availiable.");
        }

        public static void PromptPayment()
        {
            Console.WriteLine("Please enter payment for selected soda.");
        }

    }
}
