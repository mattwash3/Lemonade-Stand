using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Weather
    {
        //member variables (Has a)
        Random random;
        public string randomWeather;
        int min;
        int max;


        //constructor
        public Weather()
        {
            Random random = new Random();
        }

        //member methods (Can do)
        public void GameWeather()
        {
            WeatherForecast();
            ActualWeather();
            WeeklyWeatherForecast();
        }
        public void WeatherForecast()
        {
            //randomWeather = RandomWeather();
            Console.WriteLine("Today's weather forecast is" + randomWeather);
            switch(randomWeather)
            {

            }
            Console.ReadLine();
            Console.Clear();
        }

        public void ActualWeather()
        {

        }

        //public string RandomWeather()
        //{
        //    Console.WriteLine();
        //    Random random = new Random();
            
        //}

        public int RandomNumber()
        {
            Console.WriteLine();
            int min = 50;
            int max = 110;
            Random random = new Random();
            return random.Next(min, max);        
        }

        public void WeeklyWeatherForecast()
        {
            RandomNumber();
            Console.WriteLine("Monday weather forecast is" + random);
            Console.ReadLine();
            Console.WriteLine("Teusday weather forecast is" + random);
            Console.ReadLine();
            Console.WriteLine("Wednesday weather forecast is" + random);
            Console.ReadLine();
            Console.WriteLine("Thursday weather forecast is" + random);
            Console.ReadLine();
            Console.WriteLine("Friday weather forecast is" + random);
            Console.ReadLine();
            Console.WriteLine("Saturday weather forecast is" + random);
            Console.ReadLine();
            Console.WriteLine("Sunday weather forecast is" + random);
            Console.ReadLine();
            Console.Clear();
        }



    }
}
