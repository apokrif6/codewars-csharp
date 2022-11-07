//In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
        return listOfItems.OfType<int>(); 
   }
}
