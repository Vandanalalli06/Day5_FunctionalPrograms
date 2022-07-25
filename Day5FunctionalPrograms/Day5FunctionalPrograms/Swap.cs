using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    public class Swap
    {
        public void Swap_of_Two()
        {
            Console.WriteLine("Enter the  first number ");
            int Num1 = Convert.ToInt32(Console.ReadLine());//5
            Console.WriteLine("Enter the  second number ");
            int Num2 = Convert.ToInt32(Console.ReadLine());//4
            Console.WriteLine("Before swap Num1= " + Num1 + " Num2= " + Num2);//5,4
            Num1 = Num1 + Num2;//5+4=9
            Num2 = Num1 - Num2;//9_4=5
            Num1 = Num1 - Num2;//9-5=4
            Console.Write("After swap Num1= " + Num1 + " Num2= " + Num2);//4,5
        }
    }
}

