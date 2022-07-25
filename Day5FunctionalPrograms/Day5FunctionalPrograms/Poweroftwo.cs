using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    internal class PowerOfTwo
    {
        public void Power_Of_Two()
        {
            Console.WriteLine("Enter the number to find the power");
            int Number = Convert.ToInt32(Console.ReadLine());
            while (Number < 0 || Number >32)//Storing Int data type it takes a size of 32 bits//
            {
                Console.WriteLine("Enter a valid number");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
