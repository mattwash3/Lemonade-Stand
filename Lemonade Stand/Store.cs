using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    class Store
    {
        //member variables (Has a)
        public int totalCostLemons;
        public int totalCostSugar;
        public int totalCostIce;
        public int totalCostCups;
        public int lemons;
        public int sugar;
        public int iceCubes;
        public int cups;
        public int number;
        Random random;

        //constructor
        public Store()
        {
            totalCostLemons = 0;
            totalCostSugar = 0;
            totalCostIce = 0;
            totalCostCups = 0;
        }

        //member methods (Can do)
        public int RandomNumberSwitch()
        {
            int number;
            number = random.Next(0, 2);
            return number;
        }

        public void BuyLemons()
        {
            int lemons = RandomNumberSwitch();
            Console.WriteLine("How many lemons do you want to buy? 10 lemons for $.55, 30 lemons for $1.75, 60 lemons for $3.99");
            Random random = new Random();
            switch (lemons)
            {
                case 1:
                    Console.WriteLine("How many lemons do you want to buy?");
                    customer = ElderlyWoman();
                    break;
                case 2:
                    Console.WriteLine("Elderly Man");
                    customer = ElderlyMan();
                    break;
                case 3:
                    Console.WriteLine("Business Man");
                    customer = BusinessMan();
                    break;
            }
        }

        public void BuySugar()
        {
            int sugar = RandomNumberSwitch();
            Console.WriteLine("How many cups of sugar do you want to buy? 10 cups of sugar for $.50, 20 cups of sugar for $1.50, 50 cups of sugar for $3.45");
            switch (sugar)
            {
                case 1:
                    Console.WriteLine("How many cups of sugar do you want to buy?");
                    customer = ElderlyWoman();
                    break;
                case 2:
                    Console.WriteLine("Elderly Man");
                    customer = ElderlyMan();
                    break;
                case 3:
                    Console.WriteLine("Business Man");
                    customer = BusinessMan();
                    break;
            }
        }

        public void BuyIce()
        {
            int iceCubes = RandomNumberSwitch();
            Console.WriteLine("How many ice cubes do you want to buy? 50 ice cubes for $0.45, 125 ice cubes for $1.10, 200 ice cubes for $1.99");
            switch (iceCubes)
            {
                case 1:
                   Console.WriteLine("How many ice cubes do you want to buy?");
                   customer = ElderlyWoman();
                   break;
                case 2:
                   Console.WriteLine("Elderly Man");
                   customer = ElderlyMan();
                   break;
                case 3:
                   Console.WriteLine("Business Man");
                   customer = BusinessMan();
                   break;
            }
        }

        public void BuyCups()
        {
            int cups = RandomNumberSwitch();
            Console.WriteLine("How many cups do you want to buy? 25 cups for $0.75, 50 cups for $1.25, 100 cups for $2.50");
            switch (cups)
            {
                case 1:
                    Console.WriteLine("How many cups do you want to buy?");
                    customer = ElderlyWoman();
                    break;
                case 2:
                    Console.WriteLine("Elderly Man");
                    customer = ElderlyMan();
                    break;
                case 3:
                    Console.WriteLine("Business Man");
                    customer = BusinessMan();
                    break;
            }
        }
    }
}
