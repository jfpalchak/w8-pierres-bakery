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
      Bread newBread = new Bread(4);
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}