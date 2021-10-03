using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE ALGORITHMS PROBLEM!");
            int defCount = 0;
            while(defCount==0)
            {
                Console.WriteLine("1.FindWordBST 2.InsertionSort 3.BubbleSort 4.Exit");
                Console.WriteLine("Choose Your Option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        BinarySearch binary = new BinarySearch();
                        binary.Find();
                        break;

                    case 2:
                        InsertionSort insertion = new InsertionSort();
                        insertion.Insert();
                        break;

                    case 3:
                        BubbleSort bubble = new BubbleSort();
                        bubble.BubbleSrt();
                        break;

                    default:
                        Console.WriteLine("Exit");
                        defCount++;
                        break;

                }

            }
        }
    }
}
