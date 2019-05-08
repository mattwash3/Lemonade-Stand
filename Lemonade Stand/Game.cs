using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Game
    {
        //member variables (Has a)
        Player player1;
        public int numberOfPlayers;
        public int result;
        public int numberOfDays;
        Inventory inventory;
        Store store;
        //Customer customer;
        Day day;
        Weather weather;
        UserInterface user;




        //constructor
        public Game()
        {
            player1 = new Player();
            inventory = new Inventory();
            //store = new Store();
            //customer = new Customer();
            day = new Day();
            weather = new Weather();
            user = new UserInterface();

        }

        //member methods (Can do)
        public void RunGame()
        {
            GameStart();
            GameRules();
            GameMenu();
            GameMenuCont();
            StoreRun();
            PlayerSetup();
            Inventory();
            CustomerSetup();
            DaySetup();
            WeatherSetup();
            UserInterface();
        }

        public void GameStart()
        {
            Console.WriteLine("Welcome to Lemonade Stand! Here you are in charge of running a lemonade stand to try and make some extra cash " +
                "to buy a new bike. You have been given a small amount of start up money and supplies from your parents to get you started." +
                "The rest is up to you to make the rest of the money to get that new bike!");
            Console.ReadLine();
            Console.Clear();
        }

        public void GameRules()
        {
            Console.WriteLine("The rules are simple, make money! Oh you are curious how you do that? Gotcha! Well, you will have a certain amount of " +
                "days to make money. Each morning you will go to the store and decide if you need to spend some money to restock on more supplies " +
                "or not. After you that you will head to your stand to put together your lemonade recipe for the day that you think will earn you the" +
                "most money that day. Keep an eye on the weather as that will play a part in potential sales that day.");
            Console.ReadLine();
            Console.Clear();
        }

        public int GameMenu()
        {
            Console.WriteLine("Choose number of days to play (7, 14, 30).");
            int numberOfDays = int.Parse(Console.ReadLine());
            int result = numberOfDays;
            //int[] numbers = { 7, 14, 30 };
            if (numberOfDays == 7)
            {
                Day days = new Day();
                Console.WriteLine("You chose play for 7 days");
                Console.ReadLine();
                Console.Clear();
            }
            else if(numberOfDays == 14)
            {
                Day days = new Day();
                Console.WriteLine("You chose play for 14 days");
                Console.ReadLine();
                Console.Clear();
            }
            else if (numberOfDays == 30)
            {
                Day days = new Day();
                Console.WriteLine("You chose play for 30 days");
                Console.ReadLine();
                Console.Clear();
            }
            return numberOfDays;
        }
        public void GameMenuCont()
        {
            //set the values for assets here or in another method?
            //annotate the $20 starting money in the rules so this method can be deleted. Or just leave it out entirely and still delete this method??
            Console.WriteLine("Your assets are: $20, 5 lemons, 5 cups of sugar and 10 ice cubes.");
            Console.ReadLine();
            Console.Clear();
        }

        public void StoreRun()
        {
            Store store;

            store.RunStore(); 
            Console.WriteLine();
            //string store = Console.ReadLine();

        }

        public void PlayerSetup()
        {

        }

        public void Inventory()
        {

        }

        public void CustomerSetup()
        {

        }

        public void DaySetup()
        {

        }

        public void WeatherSetup()
        {

        }

        public void UserInterface()
        {

        }
    }
}
