//Complete the solution so that the function will break up camel casing, using a space between words.
//Example

//"camelCasing"  =>  "camel Casing"
//"identifier"   =>  "identifier"
//""             =>  ""

using System.Linq;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c.ToString() : c.ToString()))
    .TrimStart();
  }
}
