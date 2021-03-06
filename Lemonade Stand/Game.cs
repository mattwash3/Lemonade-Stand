﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Game
    {
        //member variables (Has a)
        public Player player1;
        public Player player2;
        public int numberOfPlayers;
        public int result;
        public int numberOfDays;
        public Store store;
        public Weather weather;
        public string forecast;
        //public Customer customer;

        //////////////////////
        public List<Day> days;
        public Day day;
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
            store = new Store();
            day = new Day();
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
            if (numberOfDays == 7)
            {
                day = new Day();
                Console.WriteLine("You chose: play for 7 days");
                Console.ReadLine();
                Console.Clear();
            }
            else if(numberOfDays == 14)
            {
                day = new Day();
                Console.WriteLine("You chose: play for 14 days");
                Console.ReadLine();
                Console.Clear();
            }
            else if (numberOfDays == 30)
            {
                day = new Day();
                Console.WriteLine("You chose: play for 30 days");
                Console.ReadLine();
                Console.Clear();
            }
            return numberOfDays;
        }
        public void GameMenuCont()
        {
            Console.WriteLine("Your mom has given you $20 to start your lemonade stand. At the end of the day she lets you use the freezer to store your ice in so it doesn't melt.");
            Console.ReadLine();
            Console.Clear();
        }

        public void StoreRun()
        {
            
            store.RunStore(player1.inventory); 
            Console.WriteLine();
            string restock = Console.ReadLine();

        }

        public void Inventory()
        {
            player1.inventory.DisplayInventory();
            Console.WriteLine();
            Console.ReadLine();
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
                    Console.Clear();
                }
                else if (numberOfPlayers == 2)
                {
                    player1 = new Player();
                    Console.WriteLine("Player 1");
                    Console.ReadLine();
                    player2 = new Player();
                    Console.WriteLine("Player 2");
                    Console.ReadLine();
                    Console.Clear();
                }
        }

        public void DaySetup()
        {
            day.GetDay(player1.inventory);
            Console.WriteLine();
            Console.ReadLine();
        }

        public void WeekGenerator()
        {
            Console.WriteLine();
            List<string> days = new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");
        }

        public void WeatherSetup()
        {
            weather.GameWeather();
            Console.WriteLine();
            forecast = Console.ReadLine();
            WeekGenerator();
            Console.WriteLine();

        }

        public void UserInterface()
        {

        }
    }
}
