using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_SoftUni
{
  class Car
    {
        public void CheckNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n>0)
            {
                Console.WriteLine("The number " +n+ " is positive.");
            }
            else if (n==0)
            {
                Console.WriteLine("The number" +n+ " is zero.");
            }
            else
            {
                Console.WriteLine("The number " +n+ " is negative.");
            }
            
           

        }

    }
}
