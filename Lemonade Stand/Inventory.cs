using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Inventory
    {
        //member variables (Has a)
        public int totalLemons;
        public int totalSugar;
        public int totalIce;
        public int totalCups;
        public double totalMoney;

        //constructor
        public Inventory()
        {
            totalLemons = 0;
            totalSugar = 0;
            totalIce = 0;
            totalCups = 0;
            totalMoney = 20.00;
        }

        //member methods (Can do)
        public void DisplayInventory()
        {
            Console.WriteLine("Inventory");
            Console.WriteLine("Lemons: " + totalLemons);
            Console.WriteLine("Cups of sugar: " + totalSugar);
            Console.WriteLine("Ice cubes: " + totalIce);
            Console.WriteLine("Cups: " + totalCups);
            Console.WriteLine("Wallet: " + totalMoney);
            Console.ReadLine();
        }
    }
}
