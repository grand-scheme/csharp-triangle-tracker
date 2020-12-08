using System;
using System.Collections.Generic;


namespace Triangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please input value for first side of triangle");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Please input value for second side of triangle");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Please input value for third side of triangle");
      int side3 = int.Parse(Console.ReadLine());
      Console.WriteLine(side1 + ", " + side2 + ", " + side3);

      Triangle triangle = new Triangle(side1, side2, side3);
      if (triangle.IsTriangle(side1, side2, side3))
      {
        if (triangle.IsEquilateral(side1, side2, side3))
        {
          Console.WriteLine("It is equilateral triangle");
        } 
        else if (triangle.IsIsosceles(side1, side2, side3))
        {
          Console.WriteLine("It is an isosceles triangle");
        } 
        else if (triangle.IsScalene(side1, side2, side3))
        {
          Console.WriteLine("It is a scalene triangle");
        } 
      }
      else 
      {
        Console.WriteLine("It is not a triangle");
      }
    }
  }
}