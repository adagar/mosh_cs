using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 1,
        Express = 3 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            Console.WriteLine((int)method);

            var methodID = 3;

            Console.WriteLine((ShippingMethod)methodID);

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


        }
    }
}
