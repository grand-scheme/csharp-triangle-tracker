namespace Triangle
{
  public class Triangle
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

    public bool IsTriangle(int a, int b, int c)
    {
      return (a < b + c) && (b < c + a) && (c < a + b);
    }

    public bool IsEquilateral(int a, int b, int c)
    {
      return (a == b) && (b == c) && (c == a);
    }

    public bool IsIsosceles(int a, int b, int c)
    {
      return ((a == b) && (a != c)) || ((a != b) && (a == c)) || ((b == c) && (b != a));
    }
  }
}
// a = b, /= c
// a = c, /=b
// b = c, /=a
