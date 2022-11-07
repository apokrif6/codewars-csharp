//The depth of an integer n is defined to be how many multiples of n it is necessary to compute before all 10 digits have appeared at least once in some multiple. 

using System.Collections.Generic;

namespace Solution 
{
  public class Kata 
  {
 
    public static int ComputeDepth(int n)
    {
        var toFind = new HashSet<char>(new [] { '0','1','2','3','4','5','6','7','8','9' });
        int i = 1;
      
        for (; toFind.Count > 0; i++) {
          foreach (var c in (i * n).ToString()) {
            toFind.Remove(c);
          }
        }
      
        return i - 1;
    }
  }
}
