using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
           
            Console.WriteLine("Please Enter Some text: ");
            input = Console.ReadLine();

            //reversing the whole sentence
            string reverseInput = "";
            for (int i= input.Length-1; i >= 0; i--)
            {
                reverseInput = reverseInput + input[i];
            }
            

            //reversing the each word of the sentence
            string[] words = input.Split(' ');
            string reverseEachWord = "";
            for(int i =0; i<words.Length; i++)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reverseEachWord = reverseEachWord + words[i][j];
                }

                reverseEachWord = reverseEachWord + " ";
            }
            Console.WriteLine("Here is the reverse of the sentence: ");
            Console.WriteLine(reverseInput);
            Console.WriteLine("Here is the reverse of the each word of the sentence: ");
            Console.WriteLine(reverseEachWord);
            Console.ReadKey();

        }
    }
}
