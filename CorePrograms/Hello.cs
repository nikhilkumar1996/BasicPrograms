using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class Hello
    {
        public void Replace()
        {
            Console.WriteLine("Enter your Username:");
            string username = Console.ReadLine();
            Console.WriteLine("“Hello {0},How are you?”", username);


        }
    }
}
