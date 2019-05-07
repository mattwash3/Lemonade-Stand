using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    class Weather
    {
        //member variables (Has a)
        Random random;
        int min;
        int max;


        //constructor
        public Weather()
        {

        }

        //member methods (Can do)
        public void GameWeather()
        {
            WeatherForecast();

        }
        public void WeatherForecast()
        {
            RandomNumber();
            Console.WriteLine("Today's weather forecast is" + random);
            Console.ReadLine();
            Console.Clear();
        }

        public void ActualWeather()
        {

        }

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
