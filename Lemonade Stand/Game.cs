using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Game
    {
        //member variables (Has a)
        Player player1;
        Player player2;
        public int numberOfPlayers;
        public int result;
        public int numberOfDays;
        public Inventory inventory;
        public Store store;
        Weather weather;
        //public Customer customer;

        //////////////////////
        public List<Day> days;
        //public Day day;
        //public Weather weather;
        //////////////////////
        
        //UserInterface user;
        public string restock;
        public string stock;




        //constructor
        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            inventory = new Inventory();
            store = new Store();
            //customer = new Customer();

            //////////////////////
            days = new List<Day>();
            // day = new Day();
            weather = new Weather();
            //////////////////////

            //user = new UserInterface();

        }

        //member methods (Can do)
        public void RunGame()
        {
            GameStart();
            GameRules();
            GameMenu();
            GameMenuCont();
            StoreRun();
            Inventory();
            DaySetup();
            CustomerSetup();
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
                Console.WriteLine("You chose: play for 7 days");
                Console.ReadLine();
                Console.Clear();
            }
            else if(numberOfDays == 14)
            {
                Day days = new Day();
                Console.WriteLine("You chose: play for 14 days");
                Console.ReadLine();
                Console.Clear();
            }
            else if (numberOfDays == 30)
            {
                Day days = new Day();
                Console.WriteLine("You chose: play for 30 days");
                Console.ReadLine();
                Console.Clear();
            }
            return numberOfDays;
        }
        public void GameMenuCont()
        {
            //annotate the $20 starting money in the rules so this method can be deleted. Or just leave it out entirely and still delete this method??
            PlayerSetup();
            Console.WriteLine("Your mom has given you $20 to start your lemonade stand. At the end of the day she lets you use the freezer to store your ice in so it doesn't melt.");
            Console.ReadLine();
            Console.Clear();
        }

        public void StoreRun()
        {
            store.RunStore(); 
            Console.WriteLine();
            string restock = Console.ReadLine();

        }

        public void Inventory()
        {
            inventory.DisplayInventory();
            Console.WriteLine();
            string stock = Console.ReadLine();
        }

        public void PlayerSetup()
        {
                Console.WriteLine("How many players? 1 or 2");
                int numberOfPlayers = int.Parse(Console.ReadLine());
                int result = numberOfPlayers;
                int[] number = { 1, 2 };
                if (numberOfPlayers == 1)
                {
                    player1 = new Player();
                    Console.WriteLine("Player 1");
                    //player2 = new Computer();
                    //Console.Clear();
                }
                else if (numberOfPlayers == 2)
                {
                    player1 = new Player();
                    Console.WriteLine("Player 1");
                    player2 = new Player();
                    Console.WriteLine("Player 2");
                    Console.Clear();
                }
        }

        public void DaySetup()
        {

        }

        public void WeatherSetup()
        {
            weather.GameWeather();
            Console.WriteLine();
            string forecast = Console.ReadLine();
        }

        public void CustomerSetup()
        {

        }

        public void UserInterface()
        {

        }
    }
}
