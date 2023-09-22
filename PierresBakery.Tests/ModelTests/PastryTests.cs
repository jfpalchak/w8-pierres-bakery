using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  [TestClass]
  public class PastryTests
  {
    // STATIC PRICE
    [TestMethod]
    public void GetPrice_ReturnsPriceOfPastry_Int()
    {
      int price = Pastry.Price;

      Assert.AreEqual(2, price);
    }

    // STATIC NTH PASTRY FREE
    [TestMethod]
    public void GetNthPastryFree_ReturnsNthPastryThatIsFree_Int()
    {
      int nthPastryFree = Pastry.NthPastryFree;

      Assert.AreEqual(4, nthPastryFree);
    }

    // STATIC ORDER METHOD
    [TestMethod]
    public void Order_ReturnsCostOfSinglePastry_Int()
    {
      int cost = Pastry.Order(1);

      Assert.AreEqual(2, cost);
    }

    [TestMethod]
    public void Order_ReturnsCostOfTwoPastries_Int()
    {
      int cost = Pastry.Order(2);

      Assert.AreEqual(4, cost);
    }

    [TestMethod]
    public void Order_ReturnsCostOfFourPastries_Int()
    {
      int cost = Pastry.Order(4);

      Assert.AreEqual(6, cost);
    }

    [TestMethod]
    public void Order_ReturnsAccurateCostOfManyPastries_Int()
    {
      int cost = Pastry.Order(8);

      Assert.AreEqual(12, cost);
    }
  }
}