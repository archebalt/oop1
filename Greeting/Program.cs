using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Dividelt //Greeter
    {
        static void Main(string[] args)
        {
            /*string myName;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName); 
            */
            int i, j;
            string temp;
            Console.WriteLine("Please enter first number ");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);
            Console.WriteLine("Please enter second number ");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);
            try
            {
                int k = i / j;
                Console.WriteLine("k = {0}", k);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
