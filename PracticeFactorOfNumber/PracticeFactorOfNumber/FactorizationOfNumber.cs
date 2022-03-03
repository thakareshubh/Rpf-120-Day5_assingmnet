using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFactorOfNumber
{
    internal class FactorizationOfNumber
    {
        public static int n = 1;   
        public static void Factorized(int number)
        {
            while(number > 0)
            {
                
                n *= number;
                number--;

            }
            Console.WriteLine($"Factorization of number is {n}");
        }
    }
}
