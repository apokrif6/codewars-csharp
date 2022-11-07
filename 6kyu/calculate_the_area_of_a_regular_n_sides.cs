//Write the following function:

//double areaOfPolygonInsideCircle (double circleRadius , int numberOfSides)

//It should calculate the area of a regular polygon of numberOfSides, number-of-sides, or number_of_sides sides inside a circle of radius circleRadius, circle-radius, or circle_radius which passes through all the vertices of the polygon (such circle is called circumscribed circle or circumcircle). The answer should be a number rounded to 3 decimal places.

namespace Solution {
  using System;
  public class Calculator {
    public static double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
    {
      double result = (
        (circleRadius * circleRadius * numberOfSides)
        * Math.Sin((2 * Math.PI / numberOfSides))) / 2; 
                          
      return Math.Round(result, 3);
    }
  }
}