using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BubbleSort
    {
        public void BubbleSrt()
        {
            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = true;
            int temp;
            int numLength = number.Length;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (int num in number)
            {
                Console.Write(num + " ");
            }
            Console.Read();
        }
    }
}
