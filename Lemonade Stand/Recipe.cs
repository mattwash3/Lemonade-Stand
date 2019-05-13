using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Recipe
    {
        //member variables (Has a)
        public int numberLemons;
        public int numberCupsSugar;
        public int numberIceCubes;
        public int numberCups;
        public int remainingLemons;
        public int remainingSugar;
        public int remainingIce;
        public int remainingCups;
        public double pricePerCup;
        public double costPerCup;
        public double cupPrice;
        public string normal;
        public string sweet;
        public string sour;

        //constructor
        public Recipe()
        {
            cupPrice = 0;
            costPerCup = .05;
            numberLemons = 0;
            numberCupsSugar = 0;
            numberIceCubes = 0;
            numberCups = 0;
            remainingLemons = 0;
            remainingSugar = 0;
            remainingIce = 0;
            remainingCups = 0;
        }

        //member methods (Can do)
        public void RecipeMaker(Inventory inventory)
        {
            Lemons(inventory);
            CupsOfSugar(inventory);
            IceCubes(inventory);
            CupsPerPitcher(inventory);
            PricePerCup(inventory);
        }

        public void Lemons(Inventory inventory)
        {
            Console.WriteLine("How many lemons do you want to use per pitcher?");
            numberLemons = int.Parse(Console.ReadLine());
            remainingLemons = inventory.totalLemons -= numberLemons;
            Console.WriteLine(inventory.totalLemons);
            Console.WriteLine("Lemons per pitcher " + remainingLemons);
        }

        public void CupsOfSugar(Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar do you want to use per pitcher?");
            numberCupsSugar = int.Parse(Console.ReadLine());
            remainingSugar = inventory.totalSugar -= numberCupsSugar;
            Console.WriteLine(inventory.totalSugar);
            Console.WriteLine("Cups of sugar per pitcher " + remainingSugar);
        }

        public void IceCubes(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes do you want to use per pitcher?");
            numberIceCubes = int.Parse(Console.ReadLine());
            remainingIce = inventory.totalIce -= numberIceCubes;
            Console.WriteLine(inventory.totalIce);
            Console.WriteLine("Ice cubes per pitcher " + remainingIce);
        }

        public void CupsPerPitcher(Inventory inventory)
        {
            Console.WriteLine("How many cups do you want to make? (1 pitcher = 8 cups)");
            numberCups = int.Parse(Console.ReadLine());
            remainingCups = inventory.totalCups -= numberCups;
            Console.WriteLine(inventory.totalCups); 
            Console.WriteLine("Cups per pitcher " + remainingCups);
        }

        public void PricePerCup(Inventory inventory)
        {
            Console.WriteLine("Enter price per cup ($0.00-1.00)");
            pricePerCup = inventory.totalMoney + cupPrice;
            Console.WriteLine(pricePerCup);
            Console.WriteLine("Price per cup is " + pricePerCup);          
            Console.ReadLine();
        }
    }
}
