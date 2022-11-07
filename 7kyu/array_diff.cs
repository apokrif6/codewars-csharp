using System;
using System.Linq;
 
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
      int[] result = a.Where(n => !b.Contains(n)).ToArray();
    
      return result;
  }
}
