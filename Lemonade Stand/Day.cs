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

        public void GetRecipe(Inventory inventory)
        {
            recipe.RecipeMaker(inventory);
            Console.WriteLine();
            Console.ReadLine();
        }

        public void GetCustomers()
        {
            customer.
        }
        
        public void GetTodaysProfit()
        {

        }

    }
}
