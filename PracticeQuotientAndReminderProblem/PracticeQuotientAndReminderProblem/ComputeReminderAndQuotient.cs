using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuotientAndReminderProblem
{
    internal class ComputeReminderAndQuotient
    {
        public void compute(int divident,int divisor)
        {
            int reminder;
            int quotient=Math.DivRem(divident, divisor, out reminder);
            Console.WriteLine("quotient is :"+quotient+""+"reminder is :"+reminder);
        }
    }
}
