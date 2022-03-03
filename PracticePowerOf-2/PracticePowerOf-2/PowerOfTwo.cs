using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePowerOf_2
{
    internal class PowerOfTwo
    {
        
        
        public static void  ComputePowerTable(int number)
        {
            int a = 2^number;
            int i=2;
            int p = 1;
            while(i<=a)
            {
                i = p * i;
                Console.WriteLine($"Table of Power of 2 :{i}");
                i*=2;
            }
                    
        }
    }
}
