using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)

        {   //..determining 

            const double VAT = 0.21;
           

            Console.WriteLine("Enter a price: ");
            double price = double.Parse(Console.ReadLine());

            //..calculating 

            double vat = VAT * price;

            double result = price + vat;

            //...display 

            Console.WriteLine("Price: {0:0.00}, VAT: {1:N2}, Total: {2:N2}", price, vat, result);

            Console.ReadKey();

        }
    }
}
