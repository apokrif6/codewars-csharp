//You have a string that consists of zeroes and ones. Now choose any two adjacent positions in the string: if one of them is 0, and the other one is 1, remove these two digits from the string.

//Return the length of the resulting (smallest) string that you can get after applying this operation multiple times?

//Note: after each operation, the remaining digits are separated by spaces and thus not adjacent anymore - see the examples below.

using System;
using System.Text.RegularExpressions;

public class Kata
{
  public int ZeroAndOne(string s) => Regex.Replace(s, "10|01", "").Length;
}
