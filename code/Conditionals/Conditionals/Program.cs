using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
                Console.WriteLine("It's Morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");

            bool isGoldCust = true;

            //if(isGoldCust)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95;
            //}

            float price = (isGoldCust) ? 19.95f : 29.95f;

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("it's autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its summer");
                    break;
                default:
                    Console.WriteLine("I don't understand...");
                    break;
            }
        }
    }
}
