//Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside. The strings will not be the same length, but they may be empty ( zero length ).

public class ShortLongShort
{
  public static string Solution(string a, string b)
  {
    string res;
    
    if (a.Length > b.Length) {
      res = b + a + b;
    } else {
      res = a + b + a;
    }
    
    return res;
  }
}
