using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvertSentenceByWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "A quick brown fox jumps over the lazy dog";
            string[] words = text.Split(' ');
            Array.Reverse(words);
            text = String.Join(" ", words);
            Console.Write(text);
            Console.ReadKey();
        }
    }
}
