using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Player
    {
        //member variables (Has a)
        public int numbers;
        public Inventory inventory;
        public int number;


        //constructor
        public Player()
        {
            inventory = new Inventory();
        }

        //member methods (Can do)
            public void LemonadeBatch()
        {
            int[] numbers = new int [40] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40};

            Console.WriteLine("How many cups of lemonade would you like to make today? (1-40)");
            Console.ReadLine();    
        }

        public void LemonadeRecipe()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Decide what your lemonade recipe for today will be (how many lemons, cups of sugar and ice cubes? 1-15)");
            Console.ReadLine();
        }
    }
}
