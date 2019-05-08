//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Lemonade_Stand
//{
//    class Customer
    //{
//        //member variables (Has a)
//        public int randomNumberCustomers;
//        public int randomCustomer;
//        public int customer;
//        public int buyWeather;
//        public int buyRecipe;
//        public int tipChance;
//        Random random = new Random();

//        //constructor
//        public Customer()
//        {

//        }

//        //member methods (Can do)
//        public int RandomNumberSwitch()
//        {
//            int number;
//            number = random.Next(0, 7);
//            return number;
//        }

//        public int RandomNumber()
//        {
//            Console.WriteLine();
//            int min = 40;
//            int max = 110;
//            Random random = new Random();
//            return random.Next(min, max);

//        }
//        public int CustomerCount()
//        {

//            //check on randomnumbercustomers for switch case 
//            int randomNumberCustomers = RandomNumber();
//            int randomCustomer = RandomNumberSwitch();
//            Console.WriteLine("Number of customers who visited your lemonade stand");
//                int min = 45;
//                int max = 100;
//                Random random = new Random();
//            switch (randomCustomer)
//            {
//                case 1:
//                    Console.WriteLine("Elderly Woman");
//                    customer = ElderlyWoman();
//                    break;
//                case 2:
//                    Console.WriteLine("Elderly Man");
//                    customer = ElderlyMan();
//                    break;
//                case 3:
//                    Console.WriteLine("Business Man");
//                    customer = BusinessMan();
//                    break;
//                case 4:
//                    Console.WriteLine("Soccer Mom");
//                    customer = SoccerMom();
//                    break;
//                case 5:
//                    Console.WriteLine("Neighbor");
//                    customer = Neighbor();
//                    break;
//                case 6:
//                    Console.WriteLine("Student");
//                    customer = Student();
//                    break;
//                case 7:
//                    Console.WriteLine("Athlete");
//                    customer = Athlete();
//                    break;
//                case 8:
//                    Console.WriteLine("Monster");
//                    customer = Monster();
//                    break;
//            }
//            return random.Next(min, max);            
//        }


//        //buy chance is how likely they are to buy lemonade

//        public int ElderlyWoman()
//        {

//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int ElderlyMan()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int BusinessMan()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int SoccerMom()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int Neighbor()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int Student()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int Athlete()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }

//        public int Monster()
//        {
//            int buyWeather = ;
//            int buyRecipe = ;
//            int tipChance = ;
//        }
//    }
//}
