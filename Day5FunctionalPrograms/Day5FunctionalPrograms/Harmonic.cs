using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FunctionalPrograms
{
    internal class HarmonicNumber//Sum of reciprocal of first N natural number//
    {
        public void Harmonics()
        {
            float Result_Harmonic = 0;
            Console.WriteLine("Enter the value of N for the Nth Harmonics:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (float i = 1; i <= N; i++)
            {
                Result_Harmonic += 1 / i;
            }
            Console.WriteLine("The Nth Harmonic is given by {0}", Result_Harmonic);
        }
    }
}

