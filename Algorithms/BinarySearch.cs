using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BinarySearch
    {
        public void Find()
        {
            string InputPara = "Experience is the name everyone gives to their mistakes";
            string[] para = InputPara.Split(" ");

            Array.Sort(para);

            Console.WriteLine("Insert The Word You Want To Find");
            string find = Console.ReadLine();

            int i = Array.BinarySearch(para, find);

            if(i>=0)
            {
                Console.WriteLine("Word Found At Position :" + i);
            }
            else
            {
                Console.WriteLine("Word Not Found");
            }
        }
    }
}
