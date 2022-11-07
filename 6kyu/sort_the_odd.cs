//Task

//You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
      var sortedList = new List<int>(array);
      var oddNumbers = sortedList.Where(x => x % 2 == 1).OrderBy(x => x).ToList();
      var oddIndex = 0;
    
      return sortedList.Select(x => (x % 2 == 1) ? oddNumbers[oddIndex++] : x).ToArray();  
  }
}
