 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace given_number_is_even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("the given number is even");
                Console.ReadLine();
            }
  else
            { 
          Console.WriteLine("the given number is odd");
                Console.ReadLine();
  }
        }
    }
}
