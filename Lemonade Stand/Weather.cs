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
        public string conditions;
        public string motherNature;
        public string daily;
        public string forecast;
        public int temperature;
        public string number;
        public string condition;

        //constructor
        public Weather()
        {
            random = new Random();
        }

        //member methods (Can do)
        public void GameWeather()
        {
            //WeatherForecast();
            //ActualWeather();
            WeeklyWeatherForecast();
        }
        public void WeatherForecast()
        {
            int conditions = RandomWeather();
            //Console.WriteLine("Today's weather forecast is" + conditions);
            //string forecast = Console.ReadLine();
            switch(conditions)
            {
                case 1:
                    Console.WriteLine("Weather condition: Hazy");
                    condition = "hazy";
                    break;
                case 2:
                    Console.WriteLine("Weather condition: Rainy");
                    condition = "rainy";
                    break;
                case 3:
                    Console.WriteLine("Weather condition: Sunny");
                    condition = "sunny";
                    break;
                case 4:
                    Console.WriteLine("Weather condition: Overcast");
                    condition = "overcast";
                    break;
                case 5:
                    Console.WriteLine("Weather condition: Humid");
                    condition = "humid";
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
            Console.WriteLine();
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
            WeatherForecast();
            ActualWeather();
            forecast = condition;
            temperature = RandomNumber();
            daily = forecast + temperature;
            Console.WriteLine("Today's weather forecast is" + daily);
            Console.Clear();
        }



    }
}
