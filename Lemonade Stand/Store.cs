using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    class Store
    {
        //member variables (Has a)


        //constructor
        public Store()
        {

        }

        //member methods (Can do)
        public void BuyLemons()
        {
            Console.WriteLine("How many lemons do you want to buy? 5 lemons for $.25, 10 lemons for $.50, 20 lemons for $1.00, 40 lemons for $2.00");
            Console.ReadLine();
        }

        public void BuySugar()
        {
            Console.WriteLine("How many cups of sugar do you want to buy? 5 cups of sugar for $.20, 10 cups of sugar for $0.40, 20 cups of sugar for $0.80, 40 cups of sugar for $1.60");
            Console.ReadLine();
        }

        public void BuyIce()
        {
            Console.WriteLine("How many ice cubes do you want to buy? 5 ice cubes for $0.15, 10 ice cubes for $0.30, 20 ice cubes for $0.60, 40 ice cubes for $1.20");
            Console.ReadLine();
        }

        //public void BuySigns()
        //{
        //    Console.WriteLine();
        //    Console.ReadLine();
        //}
    }
}
