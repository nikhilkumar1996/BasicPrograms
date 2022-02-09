using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class HarmonicFunction
    {
        public void Harmonic()
        {
            int i, n;
            double s = 0.0;

            Console.WriteLine("Calculate the harmonic series and their sum:");
            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("\n Sum of Series upto {0} terms : {1} \n", n, s);
        }
    }
}
