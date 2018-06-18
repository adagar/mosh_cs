using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 5, 6, 8, 2, 14, 6 };

            //Length
            Console.WriteLine("Length:" + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 2);
            Console.WriteLine("Index of 2 is:" + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }


            //Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach(var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(numbers);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

        }
    }
}
