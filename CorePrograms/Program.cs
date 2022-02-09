using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Core Programs");
            Console.WriteLine("Enter problem statement:" +
                              "\n 1)Hello Username" +
                              "\n 2)Flip Coin"+
                              "\n 3)Exit");

            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Choice");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Hello obj1 = new Hello();
                        obj1.Replace();
                        break;

                    case 2:
                        FlipCoin obj2 = new FlipCoin();
                        obj2.Percentage();
                        break;

                    case 3:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
            
    }
}
