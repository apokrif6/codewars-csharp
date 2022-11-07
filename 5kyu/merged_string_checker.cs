//At a job interview, you are challenged to write an algorithm to check if a given string, s, can be formed from two other strings, part1 and part2.

//The restriction is that the characters in part1 and part2 should be in the same order as in s.

//The interviewer gives you the following example and tells you to figure out the rest from the given test cases.

using System;

public class StringMerger
{
  public static bool isMerge(string s, string part1, string part2)
  {
    if (s == "") {
        return part1 == "" && part2 == "";
    }
    
    bool isMerge1 = false;
    bool isMerge2 = false;
    
    if (part1.Length > 0 && s[0] == part1[0])
      isMerge1 = isMerge(s.Substring(1), part1.Substring(1), part2);
    if (part2.Length > 0 && s[0] == part2[0])
      isMerge2 = isMerge(s.Substring(1), part1, part2.Substring(1));
    
    return isMerge1 || isMerge2;
    }
}