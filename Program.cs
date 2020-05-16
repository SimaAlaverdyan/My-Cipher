using System;
using System.Collections.Generic;

namespace MyCipher
{
    class Program
    {
        static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                   'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        static List<int> IndexOfInputSentence(char[] sentence)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (sentence[i] == alphabet[j])
                    {
                        indexes.Add(j);
                    }
                }
            }
            return indexes;
        }
        static void MyCipher(char[] sentence)
        {
            List<int> index = IndexOfInputSentence(sentence);
            List<char> result = new List<char>();

            Array.Reverse(alphabet);

            for (int i = 0; i < index.Count; i++)
            {
                result.Add(alphabet[index[i]]);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Encrypted Sentence: ");

            foreach (var item in result)
            {
                Console.Write(item);
            }

            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.Write("Input Sentence: ");
            string sent = Console.ReadLine().ToLower();

            char[] CharSent = sent.ToCharArray();

            MyCipher(CharSent);

        }
    }
}
