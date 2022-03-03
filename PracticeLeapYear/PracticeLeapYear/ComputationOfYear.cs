using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLeapYear
{
    internal class ComputationOfYear
    {
        public static int Compute(int year)
        {
            if(year%4==0 && year/100!=0 && year%400==0 )
            {
                Console.WriteLine(year + "is leap year");
                
            }
            else
            {
                Console.WriteLine(year + "is not leap year");
            }
            return year;
        }
    }
}
