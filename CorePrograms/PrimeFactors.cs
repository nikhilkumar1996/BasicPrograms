using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class PrimeFactors
    {
        public void Factors()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int d = 2;
            int number = num;
            while (num > 1)
            {
                if (num % d == 0)
                {
                    Console.WriteLine("Prime Factors Of {0}={1}", number, d);
                    num = num / d;
                    continue;
                }
                else
                {


                    d = d + 1;
                }
                
            }
            

        }
    }
}
