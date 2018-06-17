using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = "Nick Garza";
            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}
            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}
