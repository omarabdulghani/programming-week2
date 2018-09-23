using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //..determining

            Console.WriteLine("Enter 1st number: ");
            int FirstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int SecondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd number: ");
            int ThirdNumber = int.Parse(Console.ReadLine());

            //..calculating

            double average = (FirstNumber + SecondNumber + ThirdNumber) / 3.0;

            //..display

            Console.WriteLine("The average is: " + average);

            Console.ReadKey();
        }
    }
}
