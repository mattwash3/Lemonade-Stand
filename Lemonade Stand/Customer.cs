using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand
{
    public class Customer
    {
        //member variables (has a)
        public int randomNumberCustomers;
        public int randomCustomer;
        public int customer;
        public double buyPrice;
        public double buyTemperature;
        Random random;

        //constructor
        public Customer()
        {
            buyTemperature = 0;
            buyPrice = 0;
            random = new Random();
        }

        //member methods (can do)
        public bool CustomerBase(double buyTemperature, double buyPrice)
        {
            if (buyTemperature >= 80 && buyPrice <= .80)
            {
                if (buyTemperature <= 70 && buyPrice >= .50)
                {
                    return true;
                }
            }
            else if (buyTemperature >= 90 && buyPrice <= .75)
            {
                if (buyTemperature <= 75 && buyPrice >= .40)
                {
                    return true;
                }
            }
            else if (buyTemperature >= 85 && buyPrice <= .60)
            {
                if (buyTemperature <= 60 && buyPrice >= .45)
                {
                    return true;
                }
            }
            else if (buyTemperature >= 70 && buyPrice <= .85)
            {
                if (buyTemperature <= 55 && buyPrice >= .35)
                {
                    return true;
                }
            }
            else (buyTemperature, buyPrice)
            {
                    return false;
            }
        }

            //public int RandomNumberSwitch()
            //{
            //    int number;
            //    number = random.Next(0, 7);
            //    return number;
            //}

            //public int RandomNumber()
            //{
            //    Console.WriteLine();
            //    int min = 40;
            //    int max = 110;
            //    random = new Random();
            //    return random.Next(min, max);

            //}
            //public int CustomerCount()
            //{
            //    int randomNumberCustomers = RandomNumber();
            //    int randomCustomer = RandomNumberSwitch();
            //    Console.WriteLine("Number of customers who visited your lemonade stand");
            //    int min = 45;
            //    int max = 100;
            //    random = new Random();
            //    switch (randomCustomer)
            //    {
            //        case 1:
            //            Console.WriteLine("Elderly Woman");
            //            customer = ElderlyWoman();
            //            break;
            //        case 2:
            //            Console.WriteLine("Elderly Man");
            //            customer = ElderlyMan();
            //            break;
            //        case 3:
            //            Console.WriteLine("Business man");
            //            customer = BusinessMan();
            //            break;
            //        case 4:
            //            Console.WriteLine("Soccer Mom");
            //            customer = SoccerMom();
            //            break;
            //        case 5:
            //            Console.WriteLine("Neighbor");
            //            customer = Neighbor();
            //            break;
            //        case 6:
            //            Console.WriteLine("Student");
            //            customer = Student();
            //            break;
            //        case 7:
            //            Console.WriteLine("Athlete");
            //            customer = Athlete();
            //            break;
            //        case 8:
            //            Console.WriteLine("Monster");
            //            customer = Monster();
            //            break;
            //    }
            //    return random.Next(min, max);
            //}
        }
    }
