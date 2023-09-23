using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemsC_.Strings
{
    /// <summary>
    /// Given a string s, find the first non-repeating character in it and return its index. 
    /// If it does not exist, return -1.
    /// </summary>
    internal class UniqueCharacters
    {
        public static int FindUniqueIndex(string s)
        {
            char[] chars=s.ToCharArray();
           

            for(int i=0; i<chars.Length; i++)
            {
                if (chars[i] != chars[i+1])
                {
                    return i;
                }
            }
         
        }
    }
}
