using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHormonicNumber
{
    internal class ComputeHormonic
    {
        public void Compute(int number)
        {
            
            int r1= 1;
            int i = 1;
            while(i < number)
            {
                r1 += 1 / i;
                i++;
            }
            Console.WriteLine(r1);
            
        }
    }
}
