//Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.

using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] Capitals(string word)
  {
      var res = new List<int>();

      for (var i = 0; i < word.Length; i++)
      {
        if (char.IsUpper(word[i]))
          res.Add(i);
      }

      return res.ToArray();
  }
}
