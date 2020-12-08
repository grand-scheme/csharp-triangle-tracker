using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_OneSideLessThanTwoOthers_True()
    {
      Triangle testTriangle = new Triangle(7,4,2);
      Assert.AreEqual(false, testTriangle.IsTriangle(7,4,2));
    }
  }
}