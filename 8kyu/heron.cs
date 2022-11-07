using System;

namespace Solution
{
  public static class Program
  {
    public static double heron(double a, double b, double c)
    {
      double s = (a + b + c) / 2;
      
      return Math.Sqrt(s * (s-a) * (s-b) * (s-c));
    }
  }
}
