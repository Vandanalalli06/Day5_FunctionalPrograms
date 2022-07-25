using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    internal class Largestnumber
    {
        public void LargestNum()
        {
            int num1, num2, num3;
            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());//67
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());//55
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());//45

            if (num1 > num2)//67>55
            {
                if (num1 > num3)//67>45
                {
                    Console.Write("The 1st Number is the greatest among three:");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three:");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd Number is the greatest among three :");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three :");
            }
        }
    }
}
