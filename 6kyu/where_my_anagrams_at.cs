//What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

//'abba' & 'baab' == true

//'abba' & 'bbaa' == true

//'abba' & 'abbba' == false

//'abba' & 'abca' == false

//Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

//anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

//anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

//anagrams('laser', ['lazing', 'lazy',  'lacer']) => []

using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    List<string> anagrams = new List<string>{};
    
    for (int i = 0; i < words.Count(); i++) {
      if (String.Concat(word.OrderBy(c => c)) == String.Concat(words[i].OrderBy(c => c)))
        anagrams.Add(words[i]);
    }
    
    return anagrams;
    }
}
