using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
   public class InsertionSort
    {
        public void Insert()
        {
            Console.WriteLine("Insert the Sentence You Want To Sort");
            string input = Console.ReadLine();

            string[] array = input.Split(" ");
            int n = array.Length;

            for(int i=1; i < n; ++i)
            {
                string key = array[i];
                int  j = i - 1;

                while(j>=0 && array[j].CompareTo(key)>0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            print(array);
            void print(string[] arr)
            {
                int n = array.Length;
                for(int i=0;i<n;++i)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
    }
}
