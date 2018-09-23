using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //..determining 

             const int MINUTE = 60;
             const int HOUR = 3600;
             

            Console.WriteLine("Enter number of seconds: ");
            int Seconds = int.Parse(Console.ReadLine());
            
            //..calculating 

            int nrOfHours = (Seconds / HOUR);

            int nrOfMinutes = (Seconds - (nrOfHours * HOUR)) / MINUTE;

            int nrOfSeconds = (Seconds - (nrOfHours * HOUR) - (nrOfMinutes * MINUTE));

            //..display

            Console.WriteLine("{0:00}:{1:00}:{2:00}", nrOfHours, nrOfMinutes, nrOfSeconds);

            Console.ReadKey();












        }
    }
}
