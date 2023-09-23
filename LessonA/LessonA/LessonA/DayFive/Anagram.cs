using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFive
{
    internal class Anagram
    {
        public static void Anagram1()
        {
            String s1 = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered.";

            string[] words = s1.Split(' ');

          
            string SortWord(string word)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }

            for (int i = 0; i < words.Length; i++)
            {
                string sortedWord1 = SortWord(words[i]);

                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        break;
                    }
                    string sortedWord2 = SortWord(words[j]);

                    if (sortedWord1 == sortedWord2)
                    {
                        Console.WriteLine($"'{words[i]}' and '{words[j]}' are anagrams.");
                    }
                }
            }
        }
    }
}
