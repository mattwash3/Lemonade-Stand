using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Day
    {
        //member variables (Has a)
        public Weather weather;
        public Customer customer;
        public Recipe recipe;

        //constructor
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            recipe = new Recipe(); 
        }

        //member methods (Can do)
        public void GetDay(Inventory inventory)
        {
            GetWeatherForecast();
            GetRecipe(inventory);
            GetCustomers();
            GetTodaysProfit();
        }

        public void GetWeatherForecast()
        {
            weather.WeeklyWeatherForecast();
            Console.WriteLine();
            Console.ReadLine();
        }


        //Single Responsibility SOLID Principle////////
        public void DayForecast()
        {
            weather.WeatherForecast();
        }

        public void DayTemperature()
        {
            weather.ActualWeather();
        }


        //Open/Closed SOLID Principle////////////
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

        public void GetRecipe(Inventory inventory)
        {
            recipe.RecipeMaker(inventory);
            Console.WriteLine();
            Console.ReadLine();
        }

        public void GetCustomers()
        {
            weather.RandomNumberCustomers();

        }
        
        public void GetTodaysProfit()
        {

        }

    }
}
