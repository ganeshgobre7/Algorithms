using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PrimeNumber
    {
        int num, i, ctr, startNo, endNo;
        public void PrimeNum()
        {
            Console.WriteLine("Insert the Starting Number of Range");
            startNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the Ending Number of Range");
            endNo = Convert.ToInt32(Console.ReadLine());

            for(num=startNo;num<=endNo;num++)
            {
                ctr = 0;
                for(int i=2; i <=num/2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                   
                }
                if (ctr == 0 && num != 1)
                {
                    Console.Write(" " + num);
                }           
            }          
        }
    }
}
