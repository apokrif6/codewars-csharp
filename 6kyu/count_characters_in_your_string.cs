//The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

//What if the string is empty? Then the result should be empty object literal, {}.

using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char c in str.ToCharArray())
            {
                if (result.ContainsKey(c))
                {
                    result[c] += 1;
                }
                else
                {
                    result[c] = 1;
                }
            }

            return result;
  }
}
