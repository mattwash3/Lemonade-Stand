using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Weather
    {
        //member variables (Has a)
        public Random random;
        public string randomWeather;
        int min;
        int max;
        public string conditions;
        public string motherNature;
        public string daily;
        public string forecast;
        public int temperature;
        public string number;
        public string condition;
        public int real;

        //constructor
        public Weather()
        {
            random = new Random();
        }

        //member methods (Can do)
        public void GameWeather()
        {
            WeeklyWeatherForecast();
        }
        public void WeatherForecast()
        {
            int conditions = RandomWeather();
            //Console.WriteLine(conditions);
            string forecast = Console.ReadLine();
            switch(conditions)
            {
                case 1:
                    condition = "Hazy";
                    break;
                case 2:
                    condition = "Rainy";
                    break;
                case 3:
                    condition = "Sunny";
                    break;
                case 4:
                    condition = "Overcast";
                    break;
                case 5:
                    condition = "Humid";
                    break;
            }
            
        }

        public int RandomWeather()
        {
            int number;
            number = random.Next(1, 5);
            return number;
        }

        public void ActualWeather()
        {
            RandomNumber();
            Console.ReadLine();
        }

        public int RandomNumber()
        {
            Console.WriteLine();
            int min = 50;
            int max = 110;
            random = new Random();
            return random.Next(min, max);        
        }

        public void WeeklyWeatherForecast()
        {
            WeatherForecast();
            ActualWeather();
            forecast = condition;
            temperature = real;
            daily = forecast + temperature;
            Console.WriteLine("Today's weather forecast is " + forecast);
            Console.WriteLine("Today's weather temperature is " + temperature);
            Console.ReadLine();
            Console.Clear();
        }

        public int RandomNumberCustomers()
        {
            Console.WriteLine();
            int min = 30;
            int max = 100;
            random = new Random();
            return random.Next(min, max);
        }
    }
}
