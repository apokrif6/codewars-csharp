//Your task is to remove all duplicate words from a string, leaving only single (first) words entries.

//Example:

//Input:

//'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

//Output:

//'alpha beta gamma delta'


using System;
using System.Linq;

public static class Kata
{
  public static string RemoveDuplicateWords(string s)
  {
    string unique = string.Join(" ", s.Split(new Char[] {' '}).Distinct());
  
    return unique; 
  }
}
