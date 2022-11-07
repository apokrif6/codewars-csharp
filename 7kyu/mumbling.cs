//This time no story, no theory. The examples below show you how to write function accum:
//Examples:

//accum("abcd") -> "A-Bb-Ccc-Dddd"
//accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
//accum("cwAt") -> "C-Ww-Aaa-Tttt"

//The parameter of accum is a string which includes only letters from a..z and A..Z.

using System;
using System.Linq;

public class Accumul 
{
  public static String Accum(string s) 
  {
      string str = s.ToLower();
      string result = "";

      for (int i = 0; i < str.Count(); i++)
      {        
        char tmpChar = str[i];
        result += char.ToUpper(tmpChar) + String.Concat(Enumerable.Repeat(tmpChar, i)) + "-";
      }
    
      return result.Substring(0, result.Length-1);
    }
}
