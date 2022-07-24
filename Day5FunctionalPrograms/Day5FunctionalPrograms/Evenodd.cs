using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    internal class Evenodd
    {
        public void EvenorOdd()
        {
            int num = 0;
            Console.WriteLine("Enter the  number to find even or odd ");
            int rem = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;//% is Modulus Operator//
            if (rem == 0)
            {
                Console.WriteLine(" {0} is an even integer.", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd integer.", num);
            }

        }
    }
}
