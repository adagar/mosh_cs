using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.next(1, 10));
            }
        }
    }
}
