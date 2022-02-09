using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class PowerOf2
    {
        public void Power()
        {
            int pow = 2;
            Console.WriteLine("Enter a range:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("{0}^{1} = {2} ", pow, i, (long)Math.Pow(pow, i));
            }

        }
    }
}
