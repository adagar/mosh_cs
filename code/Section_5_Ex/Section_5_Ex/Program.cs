using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_5_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //var divTot = 0;
            //for (var i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        divTot++;
            //    }
            //}
            //Console.WriteLine(divTot + " numbers are divisible by 3.");

            ////Ex 2
            //var sum = 0;
            //while(true)
            //{
            //    Console.Write("Give me a number, or enter 'ok' to total: ");
            //    var input = Console.ReadLine();
            //    if (input != "ok")
            //    {
            //        sum += Convert.ToInt32(input);
            //        continue;
            //    }
            //    break;
            //}
            //Console.WriteLine(sum);

            ////Ex 3
            //Console.Write("Give me a number: ");
            //var input = Convert.ToInt32(Console.ReadLine());
            //var sum = 1;
            //for(var i = input; i > 0; i--)
            //{
            //    sum *= i;
            //}
            //Console.WriteLine(sum);

            ////Ex 4
            //var random = new Random();
            //var randInt = random.Next(1, 10);
            //Console.WriteLine("Debugging, my number is: " + randInt);
            //var guess = -1;
            //var guessRemain = 4;
            //while (guessRemain > 0)
            //{
            //    Console.Write(String.Format("What number am I thinking of? {0} guesses remaining: ", guessRemain));
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if(guess == randInt)
            //    {
            //        Console.WriteLine("That's right!");
            //        break;
            //    }
            //    else if(guessRemain == 1)
            //    {
            //        Console.WriteLine("You lost, moron.");
            //    }
            //    guessRemain--;
            //}
            //Ex 5
            Console.Write("Give me a series of ints, separated by commas.");
            var userList = Console.ReadLine().Split(',');
            var largest = 0;
            foreach(var item in userList)
            {
                var itemInt = Convert.ToInt32(item);
                if (itemInt > largest)
                {
                    largest = itemInt;
                }
            }
            Console.WriteLine(largest);

        }
    }
}
