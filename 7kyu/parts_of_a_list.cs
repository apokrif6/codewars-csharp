//Write a function partlist that gives all the ways to divide a list (an array) of at least two elements into two non-empty parts.

//    Each two non empty parts will be in a pair (or an array for languages without tuples or a structin C - C: see Examples test Cases - )
//    Each part will be in a string
//    Elements of a pair must be in the same order as in the original array.

using System.Linq;

public class PartList
{
    public static string[][] Partlist(string[] arr) 
    {
        string[][] result = new string[arr.Length - 1][];
      
        for (int i = 1; i < arr.Length; i++)
        {
          string first = string.Join(" ", arr.Take(i));
          string other = string.Join(" ", arr.Skip(i));
          
          result[i - 1] = new string[]{first, other};
        }
      
        return result;
    }
}
