using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int pwLength = 10;

            var buffer = new char[pwLength];

            for(var i = 0; i < pwLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            //create string from buffer array
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
