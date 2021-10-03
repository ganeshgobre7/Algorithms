using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Anagram
    {
        public void Anagramm()
        {
            Console.WriteLine("Insert the First Word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Insert the  Second Word");
            string word2 = Console.ReadLine();

            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            if(NewWord1==NewWord2)
            {
                Console.WriteLine("Yes! Both Words Are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Both Words Are Not Anagrams", word1, word2);
            }
            Console.ReadLine();
        }
    }
}
