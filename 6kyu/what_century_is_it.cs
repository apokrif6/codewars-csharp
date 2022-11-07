//Return the century of the input year. The input will always be a 4 digit string, so there is no need for validation.
//Examples

//"1999" --> "20th"
//"2011" --> "21st"
//"2154" --> "22nd"
//"2259" --> "23rd"
//"1124" --> "12th"
//"2000" --> "20th"

using System;

public class Kata
{
  public static string WhatCentury(string year)
  {
    string end = "th";
    
    int currentYear = Int32.Parse(year);
    int cent = (currentYear / 100) + ((currentYear % 100 == 0) ? 0 : 1);

    int lastNumber = cent % 10;
    
    if (lastNumber == 1 && cent != 11)
        end = "st";
    if (lastNumber == 2 && cent != 12)
        end = "nd";
    if (lastNumber == 3 && cent != 13)
        end = "rd";
    
    return cent.ToString() + end;
  }
}
