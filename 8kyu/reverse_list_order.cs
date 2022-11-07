//In this kata you will create a function that takes in a list and returns a list with the reverse order.

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
       return Enumerable.Reverse(list).ToList();
  }
}
