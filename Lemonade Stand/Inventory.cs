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
        public int totalIceCubes;
        public double totalMoney;
        public int totalCups;
        //public double wallet;

        //constructor
        public Inventory()
        {
            totalLemons = 0;
            totalSugar = 0;
            totalIceCubes = 0;
            totalCups = 0;
            totalMoney = 20.00;
        }

        //member methods (Can do)
        public void DisplayInventory()
        {

        }
    }
}
