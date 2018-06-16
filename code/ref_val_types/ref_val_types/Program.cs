using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_val_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            //a is still 10. When you copy, a copy of that VALUE is stored in value
            //This is because this is a VALUE type
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("1: {0}, 2: {1}", array1[0], array2[0]));
            //array1 value is ACTUALLY an address to that array in memory
            //so when we copy array1 to array2, the ADDRESS is copies. So same object!
            //That's why this is a REFERENCE type
        }
    }
}
