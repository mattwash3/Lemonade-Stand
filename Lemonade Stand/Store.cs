using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Store
    {
        //member variables (Has a)
        public double totalCostLemons;
        public double totalCostSugar;
        public double totalCostIce;
        public double totalCostCups;
        public double tenLemons;
        public double thirtyLemons;
        public double sixtyLemons;
        public double tenCupsSugar;
        public double twentyCupsSugar;
        public double fiftyCupsSugar;
        public double fiftyIceCubes;
        public double oneHundredTwentyFiveIceCubes;
        public double twoHundredIceCubes;
        public double twentyFiveCups;
        public double fiftyCups;
        public double oneHundredCups;
        public string numbers;
        public double totalMoney;
        public Random random;

        //constructor
        public Store()
        {
            tenLemons = .55;
            thirtyLemons = 1.75;
            sixtyLemons = 3.99;
            tenCupsSugar = .50;
            twentyCupsSugar = 1.50;
            fiftyCupsSugar = 3.45;
            fiftyIceCubes = .45;
            oneHundredTwentyFiveIceCubes = 1.10;
            twoHundredIceCubes = 1.99;
            twentyFiveCups = .75;
            fiftyCups = 1.25;
            oneHundredCups = 2.50;
            totalCostLemons = 0;
            totalCostSugar = 0;
            totalCostIce = 0;
            totalCostCups = 0;
            totalMoney = 20.00;
            random = new Random();
            
        }

        //member methods (Can do)
        public void RunStore(Inventory inventory)
        {
            Restock(inventory);
        }

        public double RandomNumberSwitch()
        {
            double number;
            number = random.Next(1, 3);
            return number;
        }
        public void Restock(Inventory inventory)
        {
            BuyLemons(inventory);
            BuySugar(inventory);
            BuyIce(inventory);
            BuyCups(inventory);
            Wallet(inventory);
            Console.WriteLine("Remaining money is " + inventory.totalMoney);
            Console.ReadLine();
            Console.WriteLine("Lemons:" + inventory.totalLemons);
            Console.ReadLine();
            Console.WriteLine("Sugar:" + inventory.totalSugar);
            Console.ReadLine();
            Console.WriteLine("Ice Cubes:" + inventory.totalIce);
            Console.ReadLine();
            Console.WriteLine("Cups:" + inventory.totalCups);
            Console.ReadLine();
        }

        public void BuyLemons(Inventory inventory)
        {       
            Console.WriteLine("How many lemons do you want to buy? 10 lemons for $.55, 30 lemons for $1.75, 60 lemons for $3.99");
            string number = Console.ReadLine();
            switch (number)
            {
                case "10":
                    Console.WriteLine("10 Lemons");
                    totalCostLemons += tenLemons;
                    inventory.totalLemons += 10;
                    //totalLemons += 10;
                    break;
                case "30":
                    Console.WriteLine("30 lemons");
                    totalCostLemons += thirtyLemons;
                    inventory.totalLemons += 30;
                    break;
                case "60":
                    Console.WriteLine("60 lemons");
                    totalCostLemons += sixtyLemons;
                    inventory.totalLemons += 60;
                    break;
                default:
                    break;
            }
        }

        public void BuySugar(Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar do you want to buy? 10 cups of sugar for $.50, 20 cups of sugar for $1.50, 50 cups of sugar for $3.45");
            string number = Console.ReadLine();
            switch (number)
            {
                case "10":
                    Console.WriteLine("10 cups of sugar");
                    totalCostSugar += tenCupsSugar;
                    inventory.totalSugar += 10;
                    break;
                case "20":
                    Console.WriteLine("20 cups of sugar");
                    totalCostSugar += twentyCupsSugar;
                    inventory.totalSugar += 20;
                    break;
                case "50":
                    Console.WriteLine("50 cups of sugar");
                    totalCostSugar += fiftyCupsSugar;
                    inventory.totalSugar += 50;
                    break;
                default:
                    break;
            }
        }

        public void BuyIce(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes do you want to buy? 50 ice cubes for $0.45, 125 ice cubes for $1.10, 200 ice cubes for $1.99");
            string number = Console.ReadLine();
            switch (number)
            {
                case "50":
                   Console.WriteLine("50 ice cubes");
                   totalCostIce += fiftyIceCubes;
                   inventory.totalIce += 50;
                   break;
                case "125":
                   Console.WriteLine("125 ice cubes");
                   totalCostIce += oneHundredTwentyFiveIceCubes;
                   inventory.totalIce += 125;
                   break;
                case "200":
                   Console.WriteLine("200 ice cubes");
                   totalCostIce += twoHundredIceCubes;
                   inventory.totalIce += 200;
                   break;
                default:
                    break;
            }
        }

        public void BuyCups(Inventory inventory)
        {
            Console.WriteLine("How many cups do you want to buy? 25 cups for $0.75, 50 cups for $1.25, 100 cups for $2.50");
            string number = Console.ReadLine();
            switch (number)
            {
                case "25":
                    Console.WriteLine("25 cups");
                    totalCostCups += twentyFiveCups;
                    inventory.totalCups += 25;
                    break;
                case "50":
                    Console.WriteLine("50 cups");
                    totalCostCups += fiftyCups;
                    inventory.totalCups += 50;
                    break;
                case "100":
                    Console.WriteLine("100 cups");
                    totalCostCups += oneHundredCups;
                    inventory.totalCups += 100;
                    break;
                default:
                    break;
            }
        }

        public void Wallet(Inventory inventory)
        {
            inventory.totalMoney -= (totalCostLemons + totalCostSugar + totalCostIce + totalCostCups);
            Console.WriteLine(inventory.totalMoney); 
        }

    }
}
