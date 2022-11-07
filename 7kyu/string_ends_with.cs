//Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

//Examples:

//solution('abc', 'bc') // returns true
//solution('abc', 'd') // returns false

public class Kata
{
  public static bool Solution(string str, string ending)
  {
    return str.EndsWith(ending);
  }
}
