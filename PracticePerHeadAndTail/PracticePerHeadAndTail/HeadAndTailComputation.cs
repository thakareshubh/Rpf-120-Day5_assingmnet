using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePerHeadAndTail
{
    internal class HeadAndTailComputation
    {
        public static int head=0;
        public static int tail=0;
        
        ///computation of % of head and tail
        
        public void compute(int usernumber)
        {
            Random rand = new Random();
            while (usernumber!=0)
            {
                double r1=rand.NextDouble();
                if(r1<0.5)
                {
                    tail=tail+1;

                }
                else
                {
                    head=head+1;
                }
                usernumber--;
            }
            int temp1 = (head * 100) / usernumber;

            int temp2 = (tail * 100) / usernumber;
            Console.WriteLine("% of head :"+temp1);
            Console.WriteLine("% of tail :"+temp2);
        }
    }
}
