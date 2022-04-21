using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    internal class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagram(string[] words)
        {
            Dictionary<string, IList<string>> anagramPairs = new
                Dictionary<string, IList<string>>();

            for (int index = 0; index < words.Length; index++)
            {
                var wordCharArray = words[index].ToArray();

                Array.Sort(wordCharArray);

                string sortedWord = wordCharArray.ToString();
                
                if (anagramPairs.ContainsKey(sortedWord))
                    anagramPairs[sortedWord].Add(words[index]);
                
                else
                    anagramPairs.Add(
                        key: sortedWord, 
                        value: new List<string> { words[index] });
            }

            return anagramPairs.Values.ToList();
        }
    }
}
