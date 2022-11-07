//Write a function that takes in a binary string and returns the equivalent decoded text (the text is ASCII encoded).

//Each 8 bits on the binary string represent 1 character on the ASCII table.

//The input string will always be a valid binary string.

//Characters can be in the range from "00000000" to "11111111" (inclusive)

//Note: In the case of an empty binary string your function should return an empty string.

using System;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string BinaryToString(string binary)
  {
     return Encoding.ASCII.GetString(
                Enumerable.Range(0, binary.Length/ 8).Select(i => Convert.ToByte(binary.Substring(8 * i, 8), 2)).ToArray());
  }
}
