using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);

      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfPastry_Int()
    {
      Pastry newPastry = new Pastry(3);

      Assert.AreEqual(2, newPastry.Price);
    }

    [TestMethod]
    public void GetNumberOfPastries_ReturnsNumberOfPastries_Int()
    {
      int numOfPastries = 3;
      Pastry newPastry = new Pastry(numOfPastries);

      int result = newPastry.NumberOfPastries;

      Assert.AreEqual(numOfPastries, result);
    }

    [TestMethod]
    public void SetNumberOfPastries_SetsValueOfNumberOfPastries_Void()
    {
      Pastry newPastry = new Pastry(3);
      int newOrder = 5;

      newPastry.NumberOfPastries = newOrder;

      Assert.AreEqual(newOrder, newPastry.NumberOfPastries);
    }

    // ORDER METHOD
    [TestMethod]
    public void Order_ReturnsCostOfSinglePastry_Int()
    {
      Pastry newPastry = new Pastry(1);

      Assert.AreEqual(2, newPastry.Order());
    }

    [TestMethod]
    public void Order_ReturnsCostOfTwoPastries_Int()
    {
      Pastry newPastry = new Pastry(2);

      Assert.AreEqual(4, newPastry.Order());
    }
  }
}