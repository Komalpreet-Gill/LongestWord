using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("The longest word is");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));

        }
        public string MyFunctionA(string input)
        {

            string[] words = input.Split(' ');
            int wordArrayLength = words.Length;
            int[] wordLength = new int[wordArrayLength];
            int x = 0;

            foreach (var word in words) 
            {
                if (word.Length > x)
                {
                    
                    x = word.Length;
                   
                }
            }



            string currentWord = words[0];
            string nextWord;
            string longestWord = currentWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                if (nextWord.Length > longestWord.Length)
                {
                    longestWord = nextWord;
                }
                else
                {
                    longestWord = currentWord;
                }

            }
            return longestWord;
        }

    }

}
