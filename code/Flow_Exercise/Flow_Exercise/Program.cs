using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Give me a number!");
            //var userVal = Convert.ToInt16(Console.ReadLine());
            //if(userVal < 10 && userVal > 1)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            //Console.WriteLine("Give me a second number!");
            //var secVal = Convert.ToInt16(Console.ReadLine());
            //int larger = (userVal >= secVal) ? userVal : secVal;
            //Console.WriteLine(String.Format("The larger value is {0}", larger));

            Console.WriteLine("Give me a width: ");
            var width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give me a height: ");
            var height = Convert.ToInt16(Console.ReadLine());
            if(width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("Image is portrait");
            }
            else
            {
                Console.WriteLine("Image is square");
            }

        }
    }
}
