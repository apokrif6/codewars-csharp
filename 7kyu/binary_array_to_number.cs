using System;

namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray)
        {
          string binary = String.Join("", BinaryArray);
        
          return Convert.ToInt32(binary, 2);
        }
    }
}
