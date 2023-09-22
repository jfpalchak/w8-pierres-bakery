using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  [TestClass]
  public class BreadTests
  {
    // STATIC PRICE PROPERTY
    [TestMethod]
    public void GetPrice_ReturnsPriceOfBread_Int()
    {
      int price = Bread.Price;

      Assert.AreEqual(5, price);
    }

    // STATIC FREE LOAF PROPERTY
    [TestMethod]
    public void GetNthLoafFree_ReturnsNthLoafFree_Int()
    {
      int nthLoafFree = Bread.NthLoafFree;

      Assert.AreEqual(3, Bread.NthLoafFree);
    }

    // STATIC ORDER METHOD
    [TestMethod]
    public void Order_ReturnsCostOfSingleLoaf_Int()
    {
      int cost = Bread.Order(1); 

      Assert.AreEqual(5, cost);
    }

    [TestMethod]
    public void Order_ReturnsTotalCostOfTwoLoaves_Int()
    {
      int cost = Bread.Order(2);

      Assert.AreEqual(10, cost);
    }

    [TestMethod]
    public void Order_ReturnsTotalCostOfThreeLoaves_int()
    {
      int cost = Bread.Order(3);

      Assert.AreEqual(10, cost);
    }

    [TestMethod]
    public void Order_ReturnsAccurateTotalCostOfManyLoaves_int()
    {
      int cost = Bread.Order(7);

      Assert.AreEqual(25, cost);
    }

  }
}