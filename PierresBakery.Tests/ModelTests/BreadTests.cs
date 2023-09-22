using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      // Arrange
      // Act
      Bread newBread = new Bread();
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNumberOfLoaves_ReturnsNumberOfLoaves_Int()
    {
      int numOfLoaves = 3;
      Bread newBread = new Bread(numOfLoaves);

      int result = newBread.GetNumberOfLoaves();

      Assert.AreEqual(numOfLoaves, result);
    }

  }
}