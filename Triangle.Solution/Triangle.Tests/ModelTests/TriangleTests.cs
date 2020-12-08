using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_FirstSideLessThanTwoOthers_True()
    {
      Triangle testTriangle = new Triangle(7, 4, 2);
      Assert.AreEqual(false, testTriangle.IsTriangle(7, 4, 2));
    }
    [TestMethod]
    public void IsTriangle_AllSidesLessThanTwoOthers_True()
    {
      Triangle testTriangle = new Triangle(3, 9, 1);
      Assert.AreEqual(false, testTriangle.IsTriangle(3, 9, 1));
    }
    [TestMethod]
    public void IsEquilateral_AllSidesEqual_True()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual(true, testTriangle.IsEquilateral(2, 2, 2));
    }
    [TestMethod]
    public void IsIsosceles_OnlyTwoSidesEqual_True()
    {
      Triangle testTriangle = new Triangle(3, 3, 4);
      Assert.AreEqual(true, testTriangle.IsIsosceles(3, 3, 4));
    }
  }
}