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
      Bread newBread = new Bread(3);

      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNumberOfLoaves_ReturnsNumberOfLoaves_Int()
    {
      int numOfLoaves = 3;
      Bread newBread = new Bread(numOfLoaves);

      int result = newBread.NumberOfLoaves;

      Assert.AreEqual(numOfLoaves, result);
    }

    [TestMethod]
    public void SetNumberOfLoaves_ReturnsNumberOfLoaves_Void()
    {
      Bread newBread = new Bread(3);
      int newOrder = 5;

      newBread.NumberOfLoaves = newOrder;
      
      Assert.AreEqual(newOrder, newBread.NumberOfLoaves);
    }

    // [TestMethod]
    // public void 

  }
}