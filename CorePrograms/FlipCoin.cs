using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class FlipCoin
    {
        int tails = 0, heads = 0, h_per, t_per;
        public void Percentage()
        {
            int i, num;
            Console.WriteLine("Enter number of counts:");
            num = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();

            // Print random numbers between 0 and 1
            Console.WriteLine("Printing  random numbers between 0 and 1");

            for (i = 1; i <= num; i++)
            {
                double r = rand.NextDouble();
                if (r < 0.5)
                {

                    Console.WriteLine(" no of tails:" + tails);
                    tails++;
                }
                else
                {
                    Console.WriteLine("no of Heads:" + heads);
                    heads++;
                }
            }

            h_per = (heads * 100) / num;
            t_per = (tails * 100) / num;
            Console.WriteLine("Percentage of heads" + h_per);
            Console.WriteLine("Percentage of tails" + t_per);



        }
    }
}
