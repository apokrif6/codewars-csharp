//Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below. Index 0 will be considered even.

//For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.

//The input will be a lowercase string with no spaces.

//Good luck!

using System;
using System.Linq;

public static class Kata
{
  public static string[] Capitalize(string s)
  {
    return new[]
    {
      string.Concat(s.Select((x, i) => i % 2 == 0 ? char.ToUpper(x) : x)),
      string.Concat(s.Select((x, i) => i % 2 == 1 ? char.ToUpper(x) : x))
    };
  }
}
