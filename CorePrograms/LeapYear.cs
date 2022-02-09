using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 100 != 0 & year % 4 == 0)
            {
                Console.WriteLine("it is a leap year");
            }
            if (year % 100 == 0 & year % 400 == 0)
            {
                Console.WriteLine("its a leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }

        }
    }
}
